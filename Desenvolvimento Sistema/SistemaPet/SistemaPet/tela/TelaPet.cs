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
        //Conexao com o BD ( MUDAR O CAMINHO )
       // string connectionString = @"Server=.;Database=bdcadastro;Trusted_Connection=True;";

        public TelaPet()
        {
            InitializeComponent();
        }

        private void TelaPet_Load(object sender, EventArgs e)
        {
           // txtIdPet.Enabled = false;
            //txtNomePet.Enabled = false;
            //cmbTipoPet.Enabled = false;
            //txtRacaPet.Enabled = false;
            //cmbGeneroPet.Enabled = false;
            //rtbAvaliacaoPet.Enabled = false;

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

                txtNomePet.Enabled = true;
                cmbTipoPet.Enabled = true;
                txtRacaPet.Enabled = true;
                cmbGeneroPet.Enabled = true;
                rtbAvaliacaoPet.Enabled = false;
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
                rtbAvaliacaoPet.Enabled = true;
                rtbAvaliacaoPet.Focus();
            }
        }

        private void btnMeusPets_Click(object sender, EventArgs e)
        {


        }

        
    }
}
