using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace MIAUDOTE.Command
{
    internal class GerenciadorCommand
    {
        private static GerenciadorCommand instancia;
        private Stack<ICommand> historico = new Stack<ICommand>();

        private GerenciadorCommand() { }

        public static GerenciadorCommand Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new GerenciadorCommand();
                return instancia;
            }
        }

        public void ExecutarComando(ICommand comando)
        {
            comando.Executar();
            historico.Push(comando);
        }

        public void DesfazerComando()
        {
            if (historico.Count > 0)
            {
                var ultimo = historico.Pop();
                ultimo.Desfazer();
            }
        }

        public bool PodeDesfazer => historico.Count > 0;
    }
}