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
    public partial class TelaConsulta : Form
    {
        public TelaConsulta()
        {
            InitializeComponent();
        }

        private void TelaConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sistemapetDataSet4.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.db_sistemapetDataSet4.Funcionario);
            // TODO: This line of code loads data into the 'db_sistemapetDataSet3.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.db_sistemapetDataSet3.Pet);
            // TODO: This line of code loads data into the 'db_sistemapetDataSet2.Adestrador' table. You can move, or remove it, as needed.
            this.adestradorTableAdapter.Fill(this.db_sistemapetDataSet2.Adestrador);
            // TODO: This line of code loads data into the 'db_sistemapetDataSet1.Dono' table. You can move, or remove it, as needed.
            this.donoTableAdapter.Fill(this.db_sistemapetDataSet1.Dono);

        }

        private void pbFechar_Click(object sender, EventArgs e)
        {

        }
    }
}
