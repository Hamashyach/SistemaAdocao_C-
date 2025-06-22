using System;
using System.Windows.Forms;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;

namespace MIAUDOTE
{
    public partial class Adotados : Form
    {
        private IMovimentoDAO movimentoDAO;
        private Usuario usuarioLogado;
       
        public Adotados(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
            this.movimentoDAO = new MovimentoDAO(); 
            CarregarHistoricoMovimentos();
        }

        private void CarregarHistoricoMovimentos()
        {
            if (usuarioLogado != null)
            {
                // Usa o método ListarPorUsuario do MovimentoDAO para obter o histórico
                var movimentos = movimentoDAO.ListarPorUsuario(usuarioLogado.Id);
                dgvHistoricoMovimentos.DataSource = movimentos;



                dgvHistoricoMovimentos.Columns["UsuarioId"].Visible = false;
                dgvHistoricoMovimentos.Columns["AnimalId"].Visible = false; // Oculta o ID do animal se não for relevante para o usuário
                dgvHistoricoMovimentos.Columns["DataOperacao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                dgvHistoricoMovimentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado. Não é possível exibir o histórico.");
                this.Close();
            }
        }

        private void btnVoltar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}