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
    public interface IAnimalDAO
    {
        void Inserir(Animal animal);
        List<Animal> ListarAnimais();
        Animal BuscarPorId(int id);

        List<Animal> BuscarDisponivel();

        void MarcarComoAdotado(int id);
        void DesmarcarAdocao(int id);

        void Remover (int id);
    }
}
