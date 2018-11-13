using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.dominio
{
    class Adestrador : Usuario
    {
        private int idAdestrador;
        private int cpf;

        public int IdAdestrador { get => idAdestrador; set => idAdestrador = value; }
        public int Cpf { get => cpf; set => cpf = value; }
    }
}
