using SistemaPet.dominio;
using SistemaPet.repositorio;
using SistemaPet.tela;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.controlador
{
    class ControladorTelaPerfil
    {
        RepositorioDono repositorioDono = new RepositorioDono();
        RepositorioAdestrador repositorioAdestrador = new RepositorioAdestrador();
        public void obterRegistrosDono(Dono dono,int idUser)
        {
            repositorioDono.GetDonoTelaPerfil(idUser, dono);
        }
        public void obterRegistrosAdestrador(Adestrador adestrador, int idUser)
        {
            repositorioAdestrador.GetAdestradorTelaPerfil(idUser, adestrador);
        }
    }
}
