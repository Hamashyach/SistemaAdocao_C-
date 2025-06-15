using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAUDOTE.Proxy
{
    public interface Ilogin
    {
        bool Autenticar(string usuario, string senha);
    }
}
