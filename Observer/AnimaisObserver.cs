using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;

namespace MIAUDOTE.Observer
{
    internal class AnimaisObserver : IObservableAnimal
    {
        private List<IObservadorAnimal> observadores = new List<IObservadorAnimal>(); // Lista para armazenar os observadores
        private IAnimalDAO animalDAO; 

        public AnimaisObserver(IAnimalDAO animalDAO) // Construtor que recebe o AnimalDAO
        {
            this.animalDAO = animalDAO;
        }

        public void AdicionarObservador(IObservadorAnimal observador) 
        {
            observadores.Add(observador); 
        }

        public void RemoverObservador(IObservadorAnimal observador) 
        {
            observadores.Remove(observador); 
        }

        public void NotificarObservadores(List<Animal> animaisAtualizados) 
        {
            foreach (var observador in observadores) // Percorre todos os observadores
            {
                observador.Atualizar(animaisAtualizados); // Chama o método Atualizar em cada observador
            }
        }

        // Métodos que as operações que alteram a lista de animais chamarão e que notificarão os observadores
        public void MarcarAnimalComoAdotado(int animalId)
        {
            animalDAO.MarcarComoAdotado(animalId); 
            NotificarObservadores(animalDAO.BuscarDisponivel()); 
        }

        public void DesmarcarAnimalAdocao(int animalId)
        {
            animalDAO.DesmarcarAdocao(animalId); // Desmarca o animal como adotado no banco de dados
            NotificarObservadores(animalDAO.BuscarDisponivel()); 
        }

        public List<Animal> GetAnimaisDisponiveis()
        {
            return animalDAO.BuscarDisponivel(); 
        }
    }
}
    

