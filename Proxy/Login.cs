using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;

namespace MIAUDOTE.Proxy
{
    public class Login : Ilogin
    {
        private UsuarioDao dao = new UsuarioDao();

        public bool Autenticar(string usuario, string senha)
        {
            Usuario u = dao.BuscarPorNome(usuario);
            return u != null && u.Senha == senha;
        }
    }
}
