﻿using System;
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
    public partial class TelaMeusPets : Form
    {
        public TelaMeusPets()
        {
            InitializeComponent();
        }

        private void TelaMeusPets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sistemapetDataSet.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.db_sistemapetDataSet.Pet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.petTableAdapter.Fill(this.db_sistemapetDataSet.Pet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
