using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.dominio
{
    class Pet
    {
        private int idPet;
        private string nomePet;
        private string tipoPet;
        private string racaPet;
        private string generoPet;
        private string avaliacaoPet;

        public int IdPet { get => idPet; set => idPet = value; }
        public string NomePet { get => nomePet; set => nomePet = value; }
        public string TipoPet { get => tipoPet; set => tipoPet = value; }
        public string RacaPet { get => racaPet; set => racaPet = value; }
        public string GeneroPet { get => generoPet; set => generoPet = value; }
        public string AvaliacaoPet { get => avaliacaoPet; set => avaliacaoPet = value; }
    }
}
