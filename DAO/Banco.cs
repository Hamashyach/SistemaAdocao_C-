using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Models;
using MIAUDOTE.Factory;
using MIAUDOTE.Properties;
using MySql.Data.MySqlClient;

namespace MIAUDOTE.DAO
{
        public class Banco
        {
            private static string servidor = "localhost";
            private static string banco = "miaudote";
            private static string usuario = "root";
            private static string senha = "root";

            private static string stringconexao = $"Server={servidor};Database={banco};Uid={usuario};Pwd={senha};";

            public static MySqlConnection ObterConexao()
            {
                MySqlConnection conexao = new MySqlConnection(stringconexao);
                conexao.Open();
                return conexao;
            }

            public static void CriarTabelas()
            {
                try
                {
                    using (var conexao = ObterConexao())
                    using (var comando = conexao.CreateCommand())
                    {
                        comando.CommandText = @"
                        CREATE TABLE IF NOT EXISTS usuarios (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            nome VARCHAR(100),
                            email VARCHAR(100),
                            senha INT(6)
                        );

                        CREATE TABLE IF NOT EXISTS animais (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            tipo VARCHAR(50),
                            nome VARCHAR(100),
                            raca VARCHAR(50),
                            idade INT,
                            descricao TEXT,
                            adotado BOOLEAN DEFAULT FALSE
                        );

                        CREATE TABLE IF NOT EXISTS adocao (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            id_usuario INT,
                            id_animal INT,
                            data_adocao DATETIME,
                            FOREIGN KEY (id_usuario) REFERENCES usuarios(id),
                            FOREIGN KEY (id_animal) REFERENCES animais(id)
                        );

                        CREATE TABLE IF NOT EXISTS movimento (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            id_usuario INT,
                            id_animal INT,
                            tipo_operacao VARCHAR(50),
                            descricao TEXT,
                            data_hora DATETIME,
                            FOREIGN KEY (id_usuario) REFERENCES usuarios(id),
                            FOREIGN KEY (id_animal) REFERENCES animais(id)
                        );
                    ";
                        comando.ExecuteNonQuery();
                        Console.WriteLine("Tabelas criadas com sucesso.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao criar tabelas: " + ex.Message);
                }
            }
        }
    }
