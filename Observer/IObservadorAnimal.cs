using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Models;

namespace MIAUDOTE.Observer
{
    public interface IObservadorAnimal
    {
        void Atualizar(List<Animal> animaisAtualizados);
    }
}
