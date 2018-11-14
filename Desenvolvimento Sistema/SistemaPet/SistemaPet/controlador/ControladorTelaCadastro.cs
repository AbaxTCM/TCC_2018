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
        RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public ControladorTelaCadastro()
        {

        }

        public void InserirDono(Dono dono)
        {
            repositorioUsuario.salvarDono(dono);
        }

        public void InserirAdestrador(Adestrador adestrador)
        {
            repositorioUsuario.salvarAdestrador(adestrador);
        }
    }
}
