using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIAUDOTE
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        private Cadastro cadastroForm;
        private Login loginForm;

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            this.Hide(); ;
            if (cadastroForm == null || cadastroForm.IsDisposed)
            {
                cadastroForm = new Cadastro();
                cadastroForm.FormClosed += (s, args) => cadastroForm = null;
                cadastroForm.ShowDialog();

            }
            else
            {
                cadastroForm.Focus();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void botao_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new Login();
                loginForm.FormClosed += (s, args) => loginForm = null;
                loginForm.ShowDialog();
            }
            else
            {
                loginForm.Focus();
            }
        }
    }
}
