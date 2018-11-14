using SistemaPet.controlador;
using SistemaPet.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.tela
{
    public partial class TelaCadastro : Form
    {
        ControladorTelaCadastro controladorCadastro = new ControladorTelaCadastro();
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarAdestrador_Click(object sender, EventArgs e)
        {
            Adestrador adestrador = new Adestrador();

            adestrador.Nome = txtNomeAdestrador.Text;
            adestrador.Telefone = txtTelAdestrador.Text;
            adestrador.Email = txtEmailAdestrador.Text;
            adestrador.Cpf = int.Parse(mtbCpfAdestrador.Text);
            adestrador.Rua = txtRuaAdestrador.Text;
            adestrador.NumCasa = int.Parse(txtNumAdestrador.Text);
            adestrador.Bairro = txtBairroAdestrador.Text;
            adestrador.Cidade = txtCidadeAdestrador.Text;
            adestrador.Estado = cmbEstadoAdestrador.Text;
            adestrador.Senha = int.Parse(txtSenhaAdestrador.Text);

            controladorCadastro.InserirAdestrador(adestrador);
        }

        private void btnSalvarDono_Click(object sender, EventArgs e)
        {
            Dono dono = new Dono();
            dono.Nome = txtNomeAdestrador.Text;
            dono.Telefone = txtTelAdestrador.Text;
            dono.Email = txtEmailAdestrador.Text;
            dono.Rua = txtRuaAdestrador.Text;
            dono.NumCasa = int.Parse(txtNumAdestrador.Text);
            dono.Bairro = txtBairroAdestrador.Text;
            dono.Cidade = txtCidadeAdestrador.Text;
            dono.Estado = cmbEstadoAdestrador.Text;
            dono.Senha = int.Parse(txtSenhaDono.Text);

            controladorCadastro.InserirDono(dono);
        }

        private void btnCancelarAdestrador_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarDono_Click(object sender, EventArgs e)
        {

        }
    }
}
