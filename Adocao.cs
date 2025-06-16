using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;
using MIAUDOTE.Command;

namespace MIAUDOTE
{
    public partial class Adocao : Form
    {
        private IAnimalDAO animalDAO = new AnimalDAO();
        private IMovimentoDAO movimentoDAO = new MovimentoDAO();
        private GerenciadorCommand gerenciadorCommand = GerenciadorCommand.Instancia;
        private Usuario usuarioLogado;
        public Adocao(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            CarregarAnimais();

        }

        private void CarregarAnimais()
        {
            var animais = animalDAO.BuscarDisponivel();
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
                    ICommand adotarcommand = new AdotarAnimalCommand(animalSelecionado, usuarioLogado.Id, animalDAO, movimentoDAO);
                    adotarcommand.Executar();
                    gerenciadorCommand.ExecutarComando(adotarcommand);
                    nomesAdotados.Add(animalSelecionado.Nome);
                }
            }

            if (nomesAdotados.Count > 0)
                MessageBox.Show($"{string.Join(", ", nomesAdotados)} foram adotados!");

            CarregarAnimais();
        }

            void buttonDesfazer_Click(object sender, EventArgs e)
        {
            if (gerenciadorCommand.PodeDesfazer) // Verifica se há comandos para desfazer
            {
                gerenciadorCommand.DesfazerComando(); // Chama o método para desfazer
                MessageBox.Show("Última ação desfeita com sucesso!");
                CarregarAnimais(); // Recarrega a lista para refletir a mudança
            }
            else
            {
                MessageBox.Show("Não há ações para desfazer.");
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {

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
    }
}

