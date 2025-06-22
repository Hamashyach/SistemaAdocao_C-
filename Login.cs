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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string senha = textBox2.Text;

            Ilogin login = new ProxyLogin(new Proxy.Login());

            try
            {
                bool sucesso = login.Autenticar(usuario, senha); 

                if (sucesso)
                {
                    Usuario logado = new UsuarioDao().BuscarPorNome(usuario);
                    MessageBox.Show("Bem vindo ao MiauDote! Vamos encontrar um amiguinho novo para voce, " + logado.Nome); // Adicionado ", " para melhor leitura

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
                    
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro inesperado durante o login: " + ex.Message);
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicial inicialForm= new inicial();
            inicialForm.ShowDialog(); 
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
