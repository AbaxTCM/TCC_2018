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
    public partial class TelaCadastroPet : Form
    {
        ControladorTelaCadastroPet controladorPet = new ControladorTelaCadastroPet();
        public TelaCadastroPet()
        {
            InitializeComponent();
        }

        private void btnCancelarPet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.NomePet = txtNomePet.Text;
            pet.TipoPet = cmbTipoPet.Text;
            pet.RacaPet = txtRacaPet.Text;
            if(rbnFemea.Checked == true)
            {
                pet.GeneroPet = rbnFemea.Text;
            }
            else if (rbnMacho.Checked == true)
            {
                pet.GeneroPet = rbnMacho.Text;
            }

            controladorPet.InserirPet(pet);
        }
    }
}
