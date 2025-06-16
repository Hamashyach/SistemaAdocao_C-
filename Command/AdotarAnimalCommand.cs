using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIAUDOTE.DAO;
using MIAUDOTE.Models;

namespace MIAUDOTE.Command
{
    public class AdotarAnimalCommand : ICommand
    {
        private Animal animal;
        private int usuarioId;
        private IAnimalDAO animalDAO;
        private IMovimentoDAO movimentoDAO;
        private int movimentoRegistradoId;

        public string Descricao => $"Adoção do animal '{animal.Nome}'";
        public AdotarAnimalCommand(Animal animal, int usuarioId, IAnimalDAO animalDAO, IMovimentoDAO movimentoDAO)
        {
            this.animal = animal;
            this.usuarioId = usuarioId;
            this.animalDAO = animalDAO;
            this.movimentoDAO = movimentoDAO;
        }

        public void Executar()
        {
            animalDAO.MarcarComoAdotado(animal.Id);
            movimentoDAO.RegistrarMovimento(usuarioId, animal.Id, "Adoção", Descricao);

            var movimentos = movimentoDAO.ListarPorUsuario(usuarioId);
            movimentoRegistradoId = movimentos.Last().Id;
        }

        public void Desfazer()
        {
            animalDAO.DesmarcarAdocao(animal.Id);

            if (movimentoRegistradoId > 0)
            {
                movimentoDAO.RemoverMovimento(movimentoRegistradoId);
            }
        }
    }
}
