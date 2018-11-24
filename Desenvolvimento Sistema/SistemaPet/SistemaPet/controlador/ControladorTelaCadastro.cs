using SistemaPet.dominio;
using SistemaPet.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.controlador
{
    class ControladorTelaCadastro
    {
        RepositorioDono repositorioDono = new RepositorioDono();
        RepositorioAdestrador repositorioAdestrador = new RepositorioAdestrador();
        RepositorioPet repositorioPet = new RepositorioPet();
        public ControladorTelaCadastro()
        {

        }

        public void InserirDono(Dono dono)
        {
            repositorioDono.salvarDono(dono);
        }

        public void InserirAdestrador(Adestrador adestrador)
        {
            repositorioAdestrador.salvarAdestrador(adestrador);
        }

        public void AlterarDono(Dono dono)
        {
            repositorioDono.updgradeDono(dono);
        }

        public void AlterarAdestrador(Adestrador adestrador)
        {
            repositorioAdestrador.upgradeAdestrador(adestrador);
        }
    }
}
