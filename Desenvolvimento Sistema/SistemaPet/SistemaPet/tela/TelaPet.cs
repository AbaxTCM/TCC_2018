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

        private void btnIncluirPet_Click(object sender, EventArgs e)
        {
            TelaCadastroPet cadastroPet = new TelaCadastroPet();
            cadastroPet.Show();
        }
    }
}
