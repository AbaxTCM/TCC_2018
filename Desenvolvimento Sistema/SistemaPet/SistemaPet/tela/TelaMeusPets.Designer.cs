namespace SistemaPet.tela
{
    partial class TelaMeusPets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_sistemapetDataSet = new SistemaPet.db_sistemapetDataSet();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter = new SistemaPet.db_sistemapetDataSetTableAdapters.PetTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idpetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racapetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generopetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpetDataGridViewTextBoxColumn,
            this.iddonoDataGridViewTextBoxColumn,
            this.idadestradorDataGridViewTextBoxColumn,
            this.nomepetDataGridViewTextBoxColumn,
            this.tipopetDataGridViewTextBoxColumn,
            this.racapetDataGridViewTextBoxColumn,
            this.generopetDataGridViewTextBoxColumn,
            this.avaliacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.petBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_sistemapetDataSet
            // 
            this.db_sistemapetDataSet.DataSetName = "db_sistemapetDataSet";
            this.db_sistemapetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.db_sistemapetDataSet;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(840, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idpetDataGridViewTextBoxColumn
            // 
            this.idpetDataGridViewTextBoxColumn.DataPropertyName = "id_pet";
            this.idpetDataGridViewTextBoxColumn.HeaderText = "id_pet";
            this.idpetDataGridViewTextBoxColumn.Name = "idpetDataGridViewTextBoxColumn";
            this.idpetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddonoDataGridViewTextBoxColumn
            // 
            this.iddonoDataGridViewTextBoxColumn.DataPropertyName = "id_dono";
            this.iddonoDataGridViewTextBoxColumn.HeaderText = "id_dono";
            this.iddonoDataGridViewTextBoxColumn.Name = "iddonoDataGridViewTextBoxColumn";
            // 
            // idadestradorDataGridViewTextBoxColumn
            // 
            this.idadestradorDataGridViewTextBoxColumn.DataPropertyName = "id_adestrador";
            this.idadestradorDataGridViewTextBoxColumn.HeaderText = "id_adestrador";
            this.idadestradorDataGridViewTextBoxColumn.Name = "idadestradorDataGridViewTextBoxColumn";
            // 
            // nomepetDataGridViewTextBoxColumn
            // 
            this.nomepetDataGridViewTextBoxColumn.DataPropertyName = "nome_pet";
            this.nomepetDataGridViewTextBoxColumn.HeaderText = "nome_pet";
            this.nomepetDataGridViewTextBoxColumn.Name = "nomepetDataGridViewTextBoxColumn";
            // 
            // tipopetDataGridViewTextBoxColumn
            // 
            this.tipopetDataGridViewTextBoxColumn.DataPropertyName = "tipo_pet";
            this.tipopetDataGridViewTextBoxColumn.HeaderText = "tipo_pet";
            this.tipopetDataGridViewTextBoxColumn.Name = "tipopetDataGridViewTextBoxColumn";
            // 
            // racapetDataGridViewTextBoxColumn
            // 
            this.racapetDataGridViewTextBoxColumn.DataPropertyName = "raca_pet";
            this.racapetDataGridViewTextBoxColumn.HeaderText = "raca_pet";
            this.racapetDataGridViewTextBoxColumn.Name = "racapetDataGridViewTextBoxColumn";
            // 
            // generopetDataGridViewTextBoxColumn
            // 
            this.generopetDataGridViewTextBoxColumn.DataPropertyName = "genero_pet";
            this.generopetDataGridViewTextBoxColumn.HeaderText = "genero_pet";
            this.generopetDataGridViewTextBoxColumn.Name = "generopetDataGridViewTextBoxColumn";
            // 
            // avaliacaoDataGridViewTextBoxColumn
            // 
            this.avaliacaoDataGridViewTextBoxColumn.DataPropertyName = "avaliacao";
            this.avaliacaoDataGridViewTextBoxColumn.HeaderText = "avaliacao";
            this.avaliacaoDataGridViewTextBoxColumn.Name = "avaliacaoDataGridViewTextBoxColumn";
            // 
            // TelaMeusPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaMeusPets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMeusPets";
            this.Load += new System.EventHandler(this.TelaMeusPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_sistemapetDataSet db_sistemapetDataSet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private db_sistemapetDataSetTableAdapters.PetTableAdapter petTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racapetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generopetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliacaoDataGridViewTextBoxColumn;
    }
}