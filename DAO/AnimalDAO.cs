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
    public class AnimalDAO : IAnimalDAO
    {
        public void Inserir(Animal animal)
        {
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "INSERT INTO animais (tipo, nome, raca, idade) VALUES (@tipo, @nome, @raca, @idade)";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@tipo", animal.Tipo);
                    cmd.Parameters.AddWithValue("@nome", animal.Nome);
                    cmd.Parameters.AddWithValue("@raca", animal.Raca);
                    cmd.Parameters.AddWithValue("@idade", animal.Idade);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Animal> ListarAnimais()
        {
            var lista = new List<Animal>();
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "SELECT * FROM animais";
                using (var cmd = new MySqlCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tipo = reader.GetString("tipo");

                        Animal animal;
                        if (tipo.ToLower() == "gato")
                            animal = new Gato();
                        else
                            animal = new Cachorro();

                        animal.Id = reader.GetInt32("id");
                        animal.Tipo = tipo;
                        animal.Nome = reader.GetString("nome");
                        animal.Raca = reader.GetString("raca");
                        animal.Idade = reader.GetInt32("idade");
                        animal.Adotado = reader.GetBoolean("adotado");
                        lista.Add(animal);
                    }
                }
            }
            return lista;
        }
        public Animal BuscarPorId(int id)
        {
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "SELECT * FROM animais WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipo = reader.GetString("tipo");
                            
                            Animal animal;
                            if (tipo.ToLower() == "gato")
                                animal = new Gato();
                            else
                                animal = new Cachorro();

                            animal.Id = reader.GetInt32("id");
                            animal.Tipo = tipo;
                            animal.Nome = reader.GetString("nome");
                            animal.Raca = reader.GetString("raca");
                            animal.Idade = reader.GetInt32("idade");
                            animal.Adotado = reader.GetBoolean("adotado");
                            return animal;
                        }
                    }
                }
            }
            return null;
        }

        public List<Animal> BuscarDisponivel()
        {
            var lista = new List<Animal>();
            using (var conexao = Banco.ObterConexao())
            { 
                string sql = "SELECT * FROM animais WHERE adotado = 0";
                using (var cmd = new MySqlCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        string tipo = reader.GetString("tipo");
                        
                        Animal animal;
                        if (tipo.ToLower() == "gato")
                            animal = new Gato();
                        else
                            animal = new Cachorro();

                        animal.Id = reader.GetInt32("id");
                        animal.Tipo = tipo;
                        animal.Nome = reader.GetString("nome");
                        animal.Raca = reader.GetString("raca");
                        animal.Idade = reader.GetInt32("idade");
                        animal.Adotado = reader.GetBoolean("adotado");
                        lista.Add(animal);
                    }
                }
            }
            return lista;
        }
        
        public void MarcarComoAdotado(int id)
        {
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "UPDATE animais SET adotado = 1 WHERE id = @id";
                using (var cmd = new MySqlCommand(sql,conexao))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DesmarcarAdocao(int id)
        {
            using (var conexao = Banco.ObterConexao()) 
            {
                string sql = "UPDATE animais SET adotado = 0 WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        public void Remover(int id)
        {
            using (var conexao = Banco.ObterConexao())
            {
                string sql = "DELETE FROM animais WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}



