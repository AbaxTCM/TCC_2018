using SistemaPet.controlador;
using SistemaPet.dominio;
using SistemaPet.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaPet.controlador.ControladorTelaLogin;

namespace SistemaPet.tela
{
    public partial class TelaPerfil : Form
    {
        ControladorTelaCadastro controladorCadastro = new ControladorTelaCadastro();
        Dono dono = new Dono();
        ControladorTelaPerfil controladorPerfil = new ControladorTelaPerfil();
        public TelaPerfil()
        {
            int ID = Session.Instance.UserID;
            controladorPerfil.obterRegistros(dono, ID);
            InitializeComponent();
            txtIdPerfil.Text = dono.IdDono.ToString();
            txtNomePerfil.Text = dono.Nome;
            txtEmailPerfil.Text = dono.Email;
            txtTelefonePerfil.Text = dono.Telefone;
            cmbEstadoPerfil.Text = dono.Estado;
            txtCidadePerfil.Text = dono.Cidade;
            txtBairroPerfil.Text = dono.Bairro;
            txtRuaPerfil.Text = dono.Rua;
            txtNumCasaPerfil.Text = dono.NumCasa.ToString();
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterarPerfil_Click(object sender, EventArgs e)
        {
            btnAlterarPerfil.Hide();
            btnSalvarPerfil.Show();

            txtNomePerfil.ReadOnly = false;
            txtEmailPerfil.ReadOnly = false;
            txtTelefonePerfil.ReadOnly = false;
            cmbEstadoPerfil.Enabled = true;
            txtCidadePerfil.ReadOnly = false;
            txtBairroPerfil.ReadOnly = false;
            txtRuaPerfil.ReadOnly = false;
            txtNumCasaPerfil.ReadOnly = false;
            txtNomePerfil.Focus();
        }

        private void btnSalvarPerfil_Click(object sender, EventArgs e)
        {
            btnSalvarPerfil.Hide();
            btnAlterarPerfil.Show();

            txtNomePerfil.ReadOnly = true;
            txtEmailPerfil.ReadOnly = true;
            txtTelefonePerfil.ReadOnly = true;
            cmbEstadoPerfil.Enabled = false;
            txtCidadePerfil.ReadOnly = true;
            txtBairroPerfil.ReadOnly = true;
            txtRuaPerfil.ReadOnly = true;
            txtNumCasaPerfil.ReadOnly = true;

            dono.Nome = txtNomePerfil.Text;
            dono.Email = txtEmailPerfil.Text;
            dono.Telefone = txtTelefonePerfil.Text;
            dono.Estado = cmbEstadoPerfil.Text;
            dono.Cidade = txtCidadePerfil.Text;
            dono.Bairro = txtBairroPerfil.Text;
            dono.Rua = txtRuaPerfil.Text;
            dono.NumCasa = int.Parse(txtNumCasaPerfil.Text);

            controladorCadastro.AlterarDono(dono);
        }
    }
}
