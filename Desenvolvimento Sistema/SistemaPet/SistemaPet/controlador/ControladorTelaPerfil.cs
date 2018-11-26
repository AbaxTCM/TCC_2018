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
        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
        public void obterRegistrosDono(Dono dono,int idUser)
        {
            repositorioDono.GetDonoTelaPerfil(idUser, dono);
        }
        public void obterRegistrosAdestrador(Adestrador adestrador, int idUser)
        {
            repositorioAdestrador.GetAdestradorTelaPerfil(idUser, adestrador);
        }
        public void obterRegistrosFuncionario(Funcionario funcionario, int idUser)
        {
            repositorioFuncionario.GetFuncTelaPerfil(idUser, funcionario);
        }
    }
}
