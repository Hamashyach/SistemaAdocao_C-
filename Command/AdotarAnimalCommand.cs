using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;
using MIAUDOTE.Observer;

namespace MIAUDOTE.Command
{
    public class AdotarAnimalCommand : ICommand
    {
        private Animal animal;
        private int usuarioId;
        private IAnimalDAO animalDAO;
        private IMovimentoDAO movimentoDAO;
        private int movimentoRegistradoId;
        private IObservableAnimal observerAnimal;

        public string Descricao => $"Adoção do animal '{animal.Nome}'";
        public AdotarAnimalCommand(Animal animal, int usuarioId, IAnimalDAO animalDAO, IMovimentoDAO movimentoDAO, IObservableAnimal observerAnimal)
        {
            this.animal = animal;
            this.usuarioId = usuarioId;
            this.animalDAO = animalDAO;
            this.movimentoDAO = movimentoDAO;
            this.observerAnimal = observerAnimal;
        }

        public void Executar()
        {
            animalDAO.MarcarComoAdotado(animal.Id);
            movimentoRegistradoId = movimentoDAO.RegistrarMovimento(usuarioId, animal.Id, "Adoção", Descricao); // Captura o ID
        }

        public void Desfazer()
        {
            animalDAO.DesmarcarAdocao(animal.Id);

            if (movimentoRegistradoId > 0)
            {
                movimentoDAO.RemoverMovimento(movimentoRegistradoId);
            }

            observerAnimal.NotificarObservadores(animalDAO.BuscarDisponivel()); // Notifica os observadores com a lista atualizada de animais disponíveis
        }
    }
}
