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
using static SistemaPet.controlador.ControladorTelaLogin;

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
            if (Session.Instance.Funcao == "Dono")
            {
                btnSalvarPet.Hide();
                btnAlterarPet.Show();
                btnMeusPets.Enabled = true;

                txtNomePet.ReadOnly = true;
                cmbTipoPet.Enabled = false;
                txtRacaPet.ReadOnly = true;
                cmbGeneroPet.Enabled = false;
                rtbAvaliacaoPet.ReadOnly = true;
            }
            else if(Session.Instance.Funcao == "Adestrador")
            {
                btnSalvarPet.Hide();
                btnAlterarPet.Show();
                btnMeusPets.Enabled = true;

                txtNomePet.ReadOnly = true;
                cmbTipoPet.Enabled = false;
                txtRacaPet.ReadOnly = true;
                cmbGeneroPet.Enabled = false;
                rtbAvaliacaoPet.ReadOnly = true;
            }
        }

        private void btnAlterarPet_Click(object sender, EventArgs e)
        {

            if (Session.Instance.Funcao == "Dono")
            {
                btnAlterarPet.Hide();
                btnSalvarPet.Show();
                btnMeusPets.Enabled = false;

                txtNomePet.ReadOnly = false;
                cmbTipoPet.Enabled = true;
                txtRacaPet.ReadOnly = false;
                cmbGeneroPet.Enabled = true;
                rtbAvaliacaoPet.ReadOnly = false;
                txtNomePet.Focus();
            }
            else if(Session.Instance.Funcao == "Adestrador")
            {
                btnAlterarPet.Hide();
                btnSalvarPet.Show();
                btnMeusPets.Enabled = false;

                txtNomePet.ReadOnly = true;
                cmbTipoPet.Enabled = false;
                txtRacaPet.ReadOnly = true;
                cmbGeneroPet.Enabled = false;
                rtbAvaliacaoPet.ReadOnly = false;
                rtbAvaliacaoPet.Focus();
            }
        }

        private void btnMeusPets_Click(object sender, EventArgs e)
        {

        }


    }
}
