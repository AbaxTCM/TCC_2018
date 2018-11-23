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
    public partial class TelaCadastroUsuario : Form
    {
        ControladorTelaCadastro controladorCadastro = new ControladorTelaCadastro();
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelarDono_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarDono_Click(object sender, EventArgs e)
        {
            Dono dono = new Dono();
            dono.Nome = txtNomeDono.Text;
            dono.Telefone = txtTelDono.Text;
            dono.Email = txtEmailDono.Text;
            dono.Rua = txtRuaDono.Text;
            dono.NumCasa = int.Parse(txtNumDono.Text);
            dono.Bairro = txtBairroDono.Text;
            dono.Cidade = txtCidadeDono.Text;
            dono.Estado = cmbEstadoDono.Text;
            dono.Senha = txtSenhaDono.Text;

            controladorCadastro.InserirDono(dono);
        }
    }
}
