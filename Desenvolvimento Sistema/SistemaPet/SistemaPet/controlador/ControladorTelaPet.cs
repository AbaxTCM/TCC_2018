using SistemaPet.dominio;
using SistemaPet.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.controlador
{
    class ControladorTelaPet
    {
        RepositorioPet repositorioPet = new RepositorioPet();
        public ControladorTelaPet()
        {

        }

        public void InserirPetDono(Pet pet)
        {
            repositorioPet.salvarPetDono(pet);
        }

        public void updatePetDono(Pet pet)
        {
            repositorioPet.upgradePet(pet);
        }
    }
}
