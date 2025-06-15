using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIAUDOTE.Models;
using MIAUDOTE.Proxy;
using MIAUDOTE.DAO;

namespace MIAUDOTE
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private Adocao adocaoForm;

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string senha = textBox2.Text;

            Ilogin login = new ProxyLogin(new Proxy.Login());
            bool sucesso = login.Autenticar(usuario, senha);

            if (sucesso)
            {
                Usuario logado = new UsuarioDao().BuscarPorNome(usuario);
                MessageBox.Show("Bem vindo ao MiauDote! Vamos encontrar um amiguinho novo para voce" + logado.Nome);

                this.Hide();
                if (adocaoForm == null || adocaoForm.IsDisposed)
                {
                    adocaoForm = new Adocao(logado);
                    adocaoForm.FormClosed += (s, args) => adocaoForm = null;
                    adocaoForm.ShowDialog();
                }
                else
                {
                    adocaoForm.Focus();
                }

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos ou campos obrigatórios não preenchidos.");
            }

      

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicial inicialForm= new inicial();
            inicialForm.ShowDialog(); // Exibe o formulário de login como modal
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
