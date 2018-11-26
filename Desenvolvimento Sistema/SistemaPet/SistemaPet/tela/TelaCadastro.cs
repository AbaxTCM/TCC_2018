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
using static SistemaPet.controlador.ControladorTelaLogin;

namespace SistemaPet.tela
{
    public partial class TelaCadastro : Form
    {
        ControladorTelaCadastro controladorCadastro = new ControladorTelaCadastro();
        ControladorTelaPet controladorPet = new ControladorTelaPet();
        public TelaCadastro()
        {
            InitializeComponent();
            lblIdDono.Text = ("ID Dono: "+Session.Instance.UserID.ToString());
            if (Session.Instance.Funcao == "Dono")
            {
                tbcUsuario.TabPages.Remove(tbpAdestrador);
                tbcUsuario.TabPages.Remove(tbpDono);
            }
            else if(Session.Instance.Funcao == "Adestrador")
            {
                tbcUsuario.TabPages.Remove(tbpAdestrador);
                tbcUsuario.TabPages.Remove(tbpDono);
                tbcUsuario.TabPages.Remove(tbpPet);
            }
            else
            {
                tbcUsuario.TabPages.Remove(tbpPet);
            }
        }

        private void btnSalvarAdestrador_Click(object sender, EventArgs e)
        {
            if (txtNomeAdestrador.Text == "" || txtTelAdestrador.Text == "" || txtEmailAdestrador.Text == "" || txtRuaAdestrador.Text == "" || txtBairroAdestrador.Text == "" || txtCidadeAdestrador.Text == "" || cmbEstadoAdestrador.Text == "" || mtbCpfAdestrador.Text == "")
            {
                MessageBox.Show("Campos em branco, Por favor digite novamente");
                txtNomeAdestrador.Clear();
                txtTelAdestrador.Clear();
                txtEmailAdestrador.Clear();
                txtRuaAdestrador.Clear();
                txtBairroAdestrador.Clear();
                txtCidadeAdestrador.Clear();
                mtbCpfAdestrador.Clear();
                txtNomeAdestrador.Focus();
            }
            int numero;
            if (int.TryParse(txtTelAdestrador.Text, out numero))
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
            else
            {
                MessageBox.Show("Telefone inválido");
                txtTelAdestrador.Clear();
                txtTelAdestrador.Focus();
            }
        }

        private void btnSalvarDono_Click(object sender, EventArgs e)
        {
            if(txtNomeDono.Text == "" || txtTelDono.Text == "" || txtEmailDono.Text == "" || txtRuaDono.Text == "" || txtBairroDono.Text == "" || txtCidadeDono.Text == "" || cmbEstadoDono.Text == "")
            {
                MessageBox.Show("Campos em branco, Por favor digite novamente");
                txtNomeDono.Clear();
                txtTelDono.Clear();
                txtEmailDono.Clear();
                txtRuaDono.Clear();
                txtBairroDono.Clear();
                txtCidadeDono.Clear();
                txtNomeDono.Focus();
            }
            int numero;
            if (int.TryParse(txtTelDono.Text,out numero))
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
            else
            {
                MessageBox.Show("Telefone inválido");
                txtTelDono.Clear();
                txtTelDono.Focus();
            }
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
            if (txtNomePet.Text == "" || cmbTipoPet.Text == "" || txtRacaPet.Text == "" || cmbGeneroPet.Text == "")
            {
                MessageBox.Show("Campos em branco, Por favor digite novamente");
                txtNomePet.Clear();
                txtRacaPet.Clear();
                txtNomePet.Focus();
            }
            else
            {
                Pet pet = new Pet();
                pet.IdDono = Session.Instance.UserID;
                pet.NomePet = txtNomePet.Text;
                pet.TipoPet = cmbTipoPet.Text;
                pet.RacaPet = txtRacaPet.Text;
                pet.GeneroPet = cmbGeneroPet.Text;
                pet.AvaliacaoPet = rtbAvaliacao.Text;

                controladorPet.InserirPetDono(pet);
            }

        }

        private void txtConfirmarSenhaAdestrador_Leave(object sender, EventArgs e)
        {
            if(txtConfirmarSenhaAdestrador.Text != txtSenhaAdestrador.Text)
            {
                MessageBox.Show("Senhas Diferentes");
                txtSenhaAdestrador.Clear();
                txtConfirmarSenhaAdestrador.Clear();
                txtSenhaAdestrador.Focus();
            }
        }

        private void txtConfirmarSenhaDono_Leave(object sender, EventArgs e)
        {
            if(txtConfirmarSenhaDono.Text != txtSenhaDono.Text)
            {
                MessageBox.Show("Senhas Diferentes");
                txtSenhaDono.Clear();
                txtConfirmarSenhaDono.Clear();
                txtSenhaDono.Focus();
            }
        }
    }
}
