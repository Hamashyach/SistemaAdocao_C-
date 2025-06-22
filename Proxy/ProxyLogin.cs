using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Proxy;

namespace MIAUDOTE.Proxy
{
    public class ProxyLogin : Ilogin
    {
        private readonly Ilogin _realLogin;

        public ProxyLogin(Ilogin realLogin)
        {
            _realLogin = realLogin;
        }

        public bool Autenticar(string usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                
                throw new ArgumentException("Usuário e senha são obrigatórios.");
            }

            return _realLogin.Autenticar(usuario, senha);
        }
    }

}








/*public class ProxyLogin : Ilogin
{
    private Login login = new Login();
    public bool Autenticar(string usuario, string senha)
    {
        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
        {
            MessageBox.Show("Usuario e senha são obrigatórios.");
            return false;
        }

        bool autenticado = login.Autenticar(usuario, senha);

        if (!autenticado)
        {
            MessageBox.Show("usuário ou senha inválidos.");
        }

        return autenticado;
    }
}*/