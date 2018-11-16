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
    public partial class Design : Form
    {
        
        public Design()
        {
            InitializeComponent();
            
          }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if(mpPainelMenu.Width == 215)
            {
                mpPainelMenu.Width = 61;
            }
            else
            {
                mpPainelMenu.Width = 215;
            }
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbrestaurar.Visible = true;
        }

        private void pbrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbMaximizar.Visible = true;
            pbrestaurar.Visible = false;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnPerfil.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnPerfil.Image = Resources.user_silhouette;
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnPerfil.Image = Resources.user_silhouette_branco;
        }

        private void btnPets_MouseEnter(object sender, EventArgs e)
        {
            btnPets.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnPets.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnPets.Image = Resources.pet;
        }

        private void btnPets_MouseLeave(object sender, EventArgs e)
        {
            btnPets.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnPets.Image = Resources.pet_branco;
        }

        private void btnAdestradores_MouseEnter(object sender, EventArgs e)
        {
            btnAdestradores.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnAdestradores.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnAdestradores.Image = Resources.icon_handshake;
        }

        private void btnAdestradores_MouseLeave(object sender, EventArgs e)
        {
            btnAdestradores.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnAdestradores.Image = Resources.icon_handshake_branco;
        }

        private void btnComprar_MouseEnter(object sender, EventArgs e)
        {
            btnComprar.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnComprar.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnComprar.Image = Resources.shopping_cart;
        }

        private void btnComprar_MouseLeave(object sender, EventArgs e)
        {
            btnComprar.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnComprar.Image = Resources.shopping_cart_branco;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnSair.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnSair.Image = Resources.opened_door_aperture;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnSair.Image = Resources.opened_door_aperture_branco;
        }
    }
}
