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
        Adestrador adestrador = new Adestrador();
        ControladorTelaPerfil controladorPerfil = new ControladorTelaPerfil();
        public TelaPerfil()
        {
            int ID = Session.Instance.UserID;
            string funcao = Session.Instance.Funcao;
            if (funcao == "Dono")
            {
                controladorPerfil.obterRegistrosDono(dono, ID);

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
                lblPerfil.Text = funcao;
            }
            else if(funcao == "Adestrador")
            {
                controladorPerfil.obterRegistrosAdestrador(adestrador, ID);

                InitializeComponent();
                txtIdPerfil.Text = adestrador.IdAdestrador.ToString();
                txtNomePerfil.Text = adestrador.Nome;
                txtEmailPerfil.Text = adestrador.Email;
                txtTelefonePerfil.Text = adestrador.Telefone;
                cmbEstadoPerfil.Text = adestrador.Estado;
                txtCidadePerfil.Text = adestrador.Cidade;
                txtBairroPerfil.Text = adestrador.Bairro;
                txtRuaPerfil.Text = adestrador.Rua;
                txtNumCasaPerfil.Text = adestrador.NumCasa.ToString();
                lblPerfil.Text = funcao;
            }
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
            string funcao = Session.Instance.Funcao;
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

            if (funcao == "Dono")
            {
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
            else if(funcao == "Adestrador")
            {
                adestrador.Nome = txtNomePerfil.Text;
                adestrador.Email = txtEmailPerfil.Text;
                adestrador.Telefone = txtTelefonePerfil.Text;
                adestrador.Estado = cmbEstadoPerfil.Text;
                adestrador.Cidade = txtCidadePerfil.Text;
                adestrador.Bairro = txtBairroPerfil.Text;
                adestrador.Rua = txtRuaPerfil.Text;
                adestrador.NumCasa = int.Parse(txtNumCasaPerfil.Text);

                controladorCadastro.AlterarAdestrador(adestrador);
            }
        }
    }
}
