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
        private IAnimalDAO animalDAO; // Referência para o DAO de animais

        public AnimaisObserver(IAnimalDAO animalDAO) // Construtor que recebe o AnimalDAO
        {
            this.animalDAO = animalDAO; // Inicializa o AnimalDAO
        }

        public void AdicionarObservador(IObservadorAnimal observador) // Implementação do método da interface
        {
            observadores.Add(observador); // Adiciona um observador à lista
        }

        public void RemoverObservador(IObservadorAnimal observador) // Implementação do método da interface
        {
            observadores.Remove(observador); // Remove um observador da lista
        }

        public void NotificarObservadores(List<Animal> animaisAtualizados) // Implementação do método da interface
        {
            foreach (var observador in observadores) // Percorre todos os observadores
            {
                observador.Atualizar(animaisAtualizados); // Chama o método Atualizar em cada observador
            }
        }

        // Métodos que as operações que alteram a lista de animais chamarão e que notificarão os observadores
        public void MarcarAnimalComoAdotado(int animalId)
        {
            animalDAO.MarcarComoAdotado(animalId); // Marca o animal como adotado no banco de dados
            NotificarObservadores(animalDAO.BuscarDisponivel()); // Notifica os observadores com a lista atualizada de animais disponíveis
        }

        public void DesmarcarAnimalAdocao(int animalId)
        {
            animalDAO.DesmarcarAdocao(animalId); // Desmarca o animal como adotado no banco de dados
            NotificarObservadores(animalDAO.BuscarDisponivel()); // Notifica os observadores com a lista atualizada de animais disponíveis
        }

        public List<Animal> GetAnimaisDisponiveis()
        {
            return animalDAO.BuscarDisponivel(); // Retorna a lista de animais disponíveis
        }
    }
}
    

