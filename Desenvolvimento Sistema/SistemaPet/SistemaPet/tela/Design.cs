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



 
    }
}
