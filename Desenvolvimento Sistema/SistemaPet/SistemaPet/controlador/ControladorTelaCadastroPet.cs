using SistemaPet.dominio;
using SistemaPet.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.controlador
{
    class ControladorTelaCadastroPet
    {
        RepositorioPet repositorioPet = new RepositorioPet();


        public void InserirPet(Pet pet)
        {
            repositorioPet.salvarPet(pet);
        }
    }
}
