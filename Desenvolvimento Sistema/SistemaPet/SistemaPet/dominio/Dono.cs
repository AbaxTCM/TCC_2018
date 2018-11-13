using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.dominio
{
    class Dono : Usuario
    {
        private int idDono;

        public int IdDono { get => idDono; set => idDono = value; }
    }
}
