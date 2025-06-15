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
    public interface IUsuarioDAO
    {
        void Inserir(Usuario usuario);
        Usuario BuscarPorNome(string nomeUsuario);
        bool Autenticar(string nomeUsuario, string senha);
    }
}
