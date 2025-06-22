using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;
using MySql.Data.MySqlClient;

namespace MIAUDOTE.DAO
{
    public class MovimentoDAO : IMovimentoDAO
    {
        public int RegistrarMovimento(int usuarioId, int animalId, string tipoOperacao, string descricao) // Alterado para retornar int
        {
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "INSERT INTO movimento (id_usuario, id_animal, tipo_operacao, descricao, data_hora) VALUES (@usuarioId, @animalId, @tipo, @desc, NOW()); SELECT LAST_INSERT_ID();"; // Adicionado SELECT LAST_INSERT_ID()
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                    cmd.Parameters.AddWithValue("@animalId", animalId);
                    cmd.Parameters.AddWithValue("@tipo", tipoOperacao);
                    cmd.Parameters.AddWithValue("@desc", descricao);
                    return Convert.ToInt32(cmd.ExecuteScalar()); // Retorna o ID gerado
                }
            }
        }

        public List<Movimento> ListarPorUsuario(int usuarioId)
        {
            var lista = new List<Movimento>();
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "SELECT * FROM movimento WHERE id_usuario = @usuarioId ORDER BY data_hora DESC";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Movimento
                            {
                                Id = reader.GetInt32("id"),
                                UsuarioId = usuarioId,
                                AnimalId = reader.GetInt32("id_animal"),
                                TipoOperacao = reader.GetString("tipo_operacao"),
                                Descricao = reader.GetString("descricao"),
                                DataOperacao = reader.GetDateTime("data_hora")
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public void RemoverMovimento(int id)
        {
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "DELETE FROM movimento WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}