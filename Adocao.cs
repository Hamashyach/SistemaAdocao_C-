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

        private void button1_Click(object sender, EventArgs e)
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

            void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

