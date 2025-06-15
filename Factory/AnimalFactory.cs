using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Models;


namespace MIAUDOTE.Factory
{
    public static class AnimalFactory
    {
        public static Animal CriarAnimal(string tipo)
        {
            if (tipo.ToLower() == "gato")
                return new Gato();
            else if (tipo.ToLower() == "cachorro")
                return new Cachorro();
            else
                throw new ArgumentException("Tipo de animal inválido.");
        }
    }
}
