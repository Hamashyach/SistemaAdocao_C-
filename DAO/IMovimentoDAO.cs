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
        int RegistrarMovimento(int usuarioId, int animalId, string tipoOperacao, string descricao); 
        List<Movimento> ListarPorUsuario(int usuarioId);
        void RemoverMovimento(int id);
    }
}
