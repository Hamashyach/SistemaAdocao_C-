using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.Models;

namespace MIAUDOTE.Observer
{
    public interface IObservableAnimal
    {
        void AdicionarObservador(IObservadorAnimal observador);
        void RemoverObservador(IObservadorAnimal observador);
        void NotificarObservadores(List<Animal> animaisAtualizados);
    }
}
