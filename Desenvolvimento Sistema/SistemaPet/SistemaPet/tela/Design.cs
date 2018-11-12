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
        int LarguraPainel;
        Boolean Esconder;

        public Design()
        {
            InitializeComponent();
            LarguraPainel = mpPainelMenu.Width;
            Esconder = false;
        }

        private void mlbMenuTopo_Click(object sender, EventArgs e)
        {
            
        }

        private void mbEsconder_Click(object sender, EventArgs e)
        {
            if(Esconder) mbEsconder.Text = "-";
            else mbEsconder.Text = "+";
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (Esconder) {
                mpPainelMenu.Width = mpPainelMenu.Width + 50;
                if(mpPainelMenu.Width >= LarguraPainel) {
                    timerMenu.Stop();
                    Esconder = false;
                    this.Refresh();
                }
            }
            else {
                mpPainelMenu.Width = mpPainelMenu.Width - 50;
                if(mpPainelMenu.Width <= 50)
                {
                    timerMenu.Stop();
                    Esconder = true;
                    this.Refresh();
                }
            }
        }
    }
}
