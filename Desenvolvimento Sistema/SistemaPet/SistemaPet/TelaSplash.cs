using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet
{
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
            pgbCarregamentoSplash.Style = ProgressBarStyle.Continuous;
            pgbCarregamentoSplash.ForeColor = Color.FromArgb(0, 179, 161, 143);
        }

        private void pgbCarregamentoSplash_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbCarregamentoSplash.Value += 2;
            if(pgbCarregamentoSplash.Value == 100)
            {
                timer1.Enabled = false;
            }
        } 
    }
}
