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
        ControladorTelaPet controladorPet = new ControladorTelaPet();
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
            adestrador.Rua = txtRuaAdestrador.Text;
            adestrador.NumCasa = int.Parse(txtNumAdestrador.Text);
            adestrador.Bairro = txtBairroAdestrador.Text;
            adestrador.Cidade = txtCidadeAdestrador.Text;
            adestrador.Estado = cmbEstadoAdestrador.Text;
            adestrador.Senha = txtSenhaAdestrador.Text;
            adestrador.Cpf = int.Parse(mtbCpfAdestrador.Text);

            controladorCadastro.InserirAdestrador(adestrador);
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

        private void btnCancelarAdestrador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarDono_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.NomePet = txtNomePet.Text;
            pet.RacaPet = txtRacaPet.Text;
            pet.GeneroPet = cmbGeneroPet.Text;
            pet.IdPet = int.Parse(txtIdPet.Text);
            pet.AvaliacaoPet = rtbAvaliacao.Text;

            controladorPet.InserirPet(pet);

        }

        private void txtConfirmarSenhaAdestrador_Leave(object sender, EventArgs e)
        {
            if(txtSenhaAdestrador.Text != txtConfirmarSenhaAdestrador.Text)
            {
                MessageBox.Show("Senhas Diferentes");
                txtSenhaAdestrador.Clear();
                txtConfirmarSenhaAdestrador.Clear();
                txtSenhaAdestrador.Focus();
            }
        }

        private void txtConfirmarSenhaDono_Leave(object sender, EventArgs e)
        {
            if(txtSenhaDono.Text != txtConfirmarSenhaDono.Text)
            {
                MessageBox.Show("Senhas Diferentes");
                txtSenhaDono.Clear();
                txtConfirmarSenhaDono.Clear();
                txtSenhaDono.Focus();
            }
        }
    }
}
