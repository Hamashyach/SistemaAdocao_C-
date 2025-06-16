using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;

namespace MIAUDOTE
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string email = textBox4.Text.Trim();
            string senha = textBox3.Text;
            string confirmar = textBox2.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmar) )
            {
                MessageBox.Show("todos os Campos são obrigatórios.");
                return;
            }

            if (senha != confirmar)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            UsuarioDao dao = new UsuarioDao();
            if (dao.BuscarPorNome(nome) != null)
            {
                MessageBox.Show("nome de usuário já está em uso.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email inválido.");
                return;
            }

            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            try
            {
                dao.Inserir(novoUsuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Hide();
                Adocao adocaoForm = new Adocao(novoUsuario);
                adocaoForm.ShowDialog(); // Exibe o formulário de adoção como modal
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde o formulário de cadastro
            inicial inicialForm = new inicial(); // Cria uma nova instância do formulário de login
            inicialForm.ShowDialog(); // Exibe o formulário de login como modal
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
