using SistemaPet.controlador;
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
    public partial class TelaPet : Form
    {
        public TelaPet()
        {
            InitializeComponent();
        }

        ControladorTelaPet controladorPet = new ControladorTelaPet();
        private void btnSalvarPet_Click(object sender, EventArgs e)
        {
            btnSalvarPet.Hide();
            btnAlterarPet.Show();
            btnMeusPets.Enabled = true;

            txtNomePet.ReadOnly = true;
            cmbTipoPet.Enabled = false;
            txtRacaPet.ReadOnly = true;
            cmbGeneroPet.Enabled = false;
        }

        private void btnAlterarPet_Click(object sender, EventArgs e)
        {
            btnAlterarPet.Hide();
            btnSalvarPet.Show();
            btnMeusPets.Enabled = false;

            txtNomePet.ReadOnly = false;
            cmbTipoPet.Enabled = true;
            txtRacaPet.ReadOnly = false;
            cmbGeneroPet.Enabled = true;
            txtNomePet.Focus();
        }

        private void btnMeusPets_Click(object sender, EventArgs e)
        {

        }


    }
}
