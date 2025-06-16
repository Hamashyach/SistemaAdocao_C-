using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAUDOTE.Models
{
    public class Movimento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AnimalId { get; set; }
        public string TipoOperacao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}
