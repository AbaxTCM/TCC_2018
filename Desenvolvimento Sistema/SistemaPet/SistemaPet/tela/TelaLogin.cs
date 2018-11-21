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
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
           
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void lklRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.Show();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                TelaLogin teste = new TelaLogin();
                Design telaPrincipal = new Design();
                this.Hide();
                telaPrincipal.Show();
            }
        }
    }
}
