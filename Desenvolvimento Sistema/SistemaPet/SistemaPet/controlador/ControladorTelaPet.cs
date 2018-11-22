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

        public void InserirDono(Pet pet)
        {
            repositorioPet.salvarPet(pet);
        }
    }
}
