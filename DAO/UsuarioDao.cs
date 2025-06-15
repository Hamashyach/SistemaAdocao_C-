using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Models;
using MIAUDOTE.Factory;
using MIAUDOTE.Properties;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace MIAUDOTE.DAO
{
    public class UsuarioDao : IUsuarioDAO
    {
        public void Inserir(Usuario usuario)
        {
            try
            {
                using (var conexao = Banco.ObterConexao())
                {
                    string sql = "INSERT INTO usuarios (nome_usuario, email, senha) VALUES (@nome, @email, @senha)";
                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@email", usuario.Email);
                        cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao inserir usuário: " + ex.Message);
            }
        }

        public Usuario BuscarPorNome(string nomeUsuario)
        {
            try
            {
                using (var conexao = Banco.ObterConexao())
                {
                    string sql = "SELECT * FROM usuarios WHERE nome_usuario = @nome";
                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeUsuario);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Usuario
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome_usuario"),
                                    Email = reader.GetString("email"),
                                    Senha = reader.GetString("senha")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuário: " + ex.Message);
            }

            return null;
        }

        public bool Autenticar(string nomeUsuario, string senha)
        {
            var usuario = BuscarPorNome(nomeUsuario);
            if (usuario == null) return false;
            return usuario.Senha == senha;
        }
    }
}
