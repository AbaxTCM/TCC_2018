using SistemaPet.controlador;
using SistemaPet.dominio;
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

namespace SistemaPet.tela
{
    public partial class TelaPerfil : Form
    {
        public TelaPerfil()
        {
            InitializeComponent();
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
            txtEstadoPerfil.ReadOnly = false;
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
            txtEstadoPerfil.ReadOnly = true;
            txtCidadePerfil.ReadOnly = true;
            txtBairroPerfil.ReadOnly = true;
            txtRuaPerfil.ReadOnly = true;
            txtNumCasaPerfil.ReadOnly = true;
        }
    }
}
