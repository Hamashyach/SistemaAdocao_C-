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
    public partial class Perfil : Form
    {
        private Usuario usuarioLogado;
        private UsuarioDao usuarioDao = new UsuarioDao();

        public Perfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
            CarregarDadosUsuario();
        }

        private void CarregarDadosUsuario()
        {
            if (usuarioLogado != null)
            {
                textBoxNome.Text = usuarioLogado.Nome;
                textBoxEmail.Text = usuarioLogado.Email;
                // Não carregar a senha atual por segurança
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string novoNome = textBoxNome.Text.Trim();
            string novoEmail = textBoxEmail.Text.Trim();
            string senhaAtualDigitada = textBoxSenhaAtual.Text;
            string novaSenha = textBoxNovaSenha.Text;
            string confirmarNovaSenha = textBoxConfirmarNovaSenha.Text;

            // Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novoEmail))
            {
                MessageBox.Show("Nome e E-mail são obrigatórios.");
                return;
            }

            // Validação de formato de e-mail
            if (!Regex.IsMatch(novoEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // Validação de alteração de senha
            if (!string.IsNullOrWhiteSpace(novaSenha) || !string.IsNullOrWhiteSpace(confirmarNovaSenha))
            {
                if (string.IsNullOrWhiteSpace(senhaAtualDigitada))
                {
                    MessageBox.Show("Para alterar a senha, você deve informar sua senha atual.");
                    return;
                }

                if (senhaAtualDigitada != usuarioLogado.Senha)
                {
                    MessageBox.Show("Senha atual incorreta.");
                    return;
                }

                if (novaSenha != confirmarNovaSenha)
                {
                    MessageBox.Show("A nova senha e a confirmação da nova senha não coincidem.");
                    return;
                }

                usuarioLogado.Senha = novaSenha; // Atualiza a senha no objeto do usuário logado
            }

            // Verificar se o nome de usuário já existe, mas permitir que seja o próprio usuário
            if (novoNome != usuarioLogado.Nome && usuarioDao.BuscarPorNome(novoNome) != null)
            {
                MessageBox.Show("Este nome de usuário já está em uso por outro usuário.");
                return;
            }

            usuarioLogado.Nome = novoNome;
            usuarioLogado.Email = novoEmail;

            try
            {
                usuarioDao.Atualizar(usuarioLogado);
                MessageBox.Show("Dados do perfil atualizados com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o perfil: " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}