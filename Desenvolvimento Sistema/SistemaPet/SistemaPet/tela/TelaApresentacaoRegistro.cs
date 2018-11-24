using SistemaPet.Properties;
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
    public partial class TelaApresentacaoRegistro : Form
    {
        public TelaApresentacaoRegistro()
        {
            InitializeComponent();
        }

        private void btnDonoCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastroDono cadastroDono = new TelaCadastroDono();
            cadastroDono.Show();
            this.Close();
        }

        private void btnAdestradorCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastroAdestrador cadastroAdestrador = new TelaCadastroAdestrador();
            cadastroAdestrador.Show();
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDonoCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnDonoCadastro.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnDonoCadastro.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnDonoCadastro.Image = Resources.user_silhouette;
        }
        private void btnAdestradorCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnAdestradorCadastro.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnAdestradorCadastro.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnAdestradorCadastro.Image = Resources.user_silhouette;
        }
        private void btnDonoCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnDonoCadastro.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnDonoCadastro.Image = Resources.user_silhouette_branco;
        }

        private void btnAdestradorCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnAdestradorCadastro.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnAdestradorCadastro.Image = Resources.user_silhouette_branco;
        }
    }
}
