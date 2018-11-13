using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.dominio
{
    class Funcionario : Usuario
    {
        private int idFuncionario;
        private string cargoFuncionario;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string CargoFuncionario { get => cargoFuncionario; set => cargoFuncionario = value; }
    }
}
