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
    public partial class TelaCadastroDono : Form
    {
        ControladorTelaCadastro controladorCadastro = new ControladorTelaCadastro();
        public TelaCadastroDono()
        {
            InitializeComponent();
        }

        private void btnCancelarDono_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarDono_Click(object sender, EventArgs e)
        {
            if (txtNomeDono.Text == "" || txtTelDono.Text == "" || txtEmailDono.Text == "" || txtRuaDono.Text == "" || txtBairroDono.Text == "" || txtCidadeDono.Text == "" || cmbEstadoDono.Text == "")
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
            if (int.TryParse(txtTelDono.Text, out numero))
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
                this.Close();
            }
            else
            {
                MessageBox.Show("Telefone inválido");
                txtTelDono.Clear();
                txtTelDono.Focus();
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
