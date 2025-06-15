using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Models;

namespace MIAUDOTE.DAO
{
    public interface IMovimentoDAO
    {
        void RegistrarMovimento(int usuarioId, string tipoOperacao, string descricao);
        List<Movimento> ListarPorUsuario(int usuarioId);
        void RemoverMovimento(int id);
    }
}
