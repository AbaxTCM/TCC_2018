using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.dominio
{
    abstract class Usuario
    {
        private string nome;
        private string telefone;
        private string email;
        private string rua;
        private int numCasa;
        private string bairro;
        private string cidade;
        private string estado;
        private int senha;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Rua { get => rua; set => rua = value; }
        public int NumCasa { get => numCasa; set => numCasa = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Senha { get => senha; set => senha = value; }
    }
}
