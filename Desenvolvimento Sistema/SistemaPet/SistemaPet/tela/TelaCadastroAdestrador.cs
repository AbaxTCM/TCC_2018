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
    public partial class TelaCadastroAdestrador : Form
    {
        ControladorTelaCadastro controladorCadastro = new ControladorTelaCadastro();
        public TelaCadastroAdestrador()
        {
            InitializeComponent();
        }

        private void btnCancelarAdestrador_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.Close();
            }
            else
            {
                MessageBox.Show("Telefone inválido");
                txtTelAdestrador.Clear();
                txtTelAdestrador.Focus();
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
    }
}
