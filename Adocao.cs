using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIAUDOTE.Command;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;
using MIAUDOTE.Observer;

namespace MIAUDOTE
{
    public partial class Adocao : Form, IObservadorAnimal
    {
        private IAnimalDAO animalDAO = new AnimalDAO();
        private IMovimentoDAO movimentoDAO = new MovimentoDAO();
        private GerenciadorCommand gerenciadorCommand = GerenciadorCommand.Instancia;
        private Usuario usuarioLogado;
        private AnimaisObserver animaisObserver;
        public Adocao(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;

            animaisObserver = new AnimaisObserver(animalDAO);
            animaisObserver.AdicionarObservador(this); // Adiciona o observador para receber atualizações de animais
            CarregarAnimais();

        }

        public void Atualizar(List<Animal> animaisAtualizados)
        {
            // Atualiza a fonte de dados da DataGridView com a nova lista de animais
            dataGridView1.DataSource = animaisAtualizados;
            // Pode ser necessário forçar a atualização visual da DataGridView
            dataGridView1.Refresh();
        }

        private void CarregarAnimais()
        {
            var animais = animaisObserver.GetAnimaisDisponiveis();
            dataGridView1.DataSource = animais;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdotar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal.");
                return;
            }

            var nomesAdotados = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is Animal animalSelecionado)
                {
                    ICommand adotarcommand = new AdotarAnimalCommand(animalSelecionado, usuarioLogado.Id, animalDAO, movimentoDAO, animaisObserver);
                    gerenciadorCommand.ExecutarComando(adotarcommand); // Executa e empilha o comando
                    nomesAdotados.Add(animalSelecionado.Nome);
                }
            }

            if (nomesAdotados.Count == 1) { 
            MessageBox.Show($"{string.Join(", ", nomesAdotados)} foi adotados!");
            }
            else if (nomesAdotados.Count > 1)
            {
                MessageBox.Show($"{string.Join(", ", nomesAdotados)} foram adotados!");
            }
            else
            {
                MessageBox.Show("Nenhum animal selecionado para adoção.");
            }

            CarregarAnimais();
        }

        void buttonDesfazer_Click(object sender, EventArgs e)
        {
            if (gerenciadorCommand.PodeDesfazer)
            {
                gerenciadorCommand.DesfazerComando();
                MessageBox.Show("Última ação desfeita com sucesso!");
            }
            else
            {
                MessageBox.Show("Não há ações para desfazer.");
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
            Application.Exit();
        }

        private void Histórico_Click(object sender, EventArgs e)
        {
            if (usuarioLogado != null)
            {
                Adotados historicoForm = new Adotados(usuarioLogado);
                historicoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há usuário logado para visualizar o histórico.");
            }
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            if (usuarioLogado != null)
            {
                Perfil perfilForm = new Perfil(usuarioLogado); // Passa o usuário logado para o formulário de perfil
                perfilForm.ShowDialog();
                // Após fechar o perfil, recarregue os dados do usuário, caso o nome ou e-mail tenham sido alterados
                // ou apenas se for necessário para exibição imediata em alguma parte do formulário Adocao.
                // Como não há exibição direta de nome/email aqui, não é estritamente necessário.
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado. Não é possível visualizar o perfil.");
            }
        }
    }
}