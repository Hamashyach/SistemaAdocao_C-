using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAUDOTE.Models
{
    public abstract class Animal
    {
        public int Id {  get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public string descricao { get; set; }
        public bool Adotado { get; set; }
    }
}
