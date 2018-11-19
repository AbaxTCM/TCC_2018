namespace SistemaPet.tela
{
    partial class TelaPet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvaliacaoPet = new System.Windows.Forms.Label();
            this.lblGeneroPet = new System.Windows.Forms.Label();
            this.lblTipoPet = new System.Windows.Forms.Label();
            this.lblRacaPet = new System.Windows.Forms.Label();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.btnIncluirPet = new MetroFramework.Controls.MetroButton();
            this.ptbImagemPet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemPet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPet,
            this.nomePet,
            this.tipoPet,
            this.racaPet,
            this.generoPet});
            this.dataGridView1.Location = new System.Drawing.Point(166, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPet
            // 
            this.idPet.HeaderText = "Id.";
            this.idPet.Name = "idPet";
            // 
            // nomePet
            // 
            this.nomePet.HeaderText = "Nome";
            this.nomePet.Name = "nomePet";
            // 
            // tipoPet
            // 
            this.tipoPet.HeaderText = "Tipo";
            this.tipoPet.Name = "tipoPet";
            // 
            // racaPet
            // 
            this.racaPet.HeaderText = "Raça";
            this.racaPet.Name = "racaPet";
            // 
            // generoPet
            // 
            this.generoPet.HeaderText = "Gênero";
            this.generoPet.Name = "generoPet";
            // 
            // lblAvaliacaoPet
            // 
            this.lblAvaliacaoPet.AutoSize = true;
            this.lblAvaliacaoPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacaoPet.Location = new System.Drawing.Point(530, 47);
            this.lblAvaliacaoPet.Name = "lblAvaliacaoPet";
            this.lblAvaliacaoPet.Size = new System.Drawing.Size(116, 24);
            this.lblAvaliacaoPet.TabIndex = 17;
            this.lblAvaliacaoPet.Text = "##Avaliação##";
            // 
            // lblGeneroPet
            // 
            this.lblGeneroPet.AutoSize = true;
            this.lblGeneroPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroPet.Location = new System.Drawing.Point(220, 147);
            this.lblGeneroPet.Name = "lblGeneroPet";
            this.lblGeneroPet.Size = new System.Drawing.Size(100, 24);
            this.lblGeneroPet.TabIndex = 15;
            this.lblGeneroPet.Text = "##Genêro##";
            // 
            // lblTipoPet
            // 
            this.lblTipoPet.AutoSize = true;
            this.lblTipoPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPet.Location = new System.Drawing.Point(220, 80);
            this.lblTipoPet.Name = "lblTipoPet";
            this.lblTipoPet.Size = new System.Drawing.Size(77, 24);
            this.lblTipoPet.TabIndex = 12;
            this.lblTipoPet.Text = "##Tipo##";
            // 
            // lblRacaPet
            // 
            this.lblRacaPet.AutoSize = true;
            this.lblRacaPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacaPet.Location = new System.Drawing.Point(220, 113);
            this.lblRacaPet.Name = "lblRacaPet";
            this.lblRacaPet.Size = new System.Drawing.Size(84, 24);
            this.lblRacaPet.TabIndex = 11;
            this.lblRacaPet.Text = "##Raça##";
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePet.Location = new System.Drawing.Point(220, 47);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(91, 24);
            this.lblNomePet.TabIndex = 10;
            this.lblNomePet.Text = "##Nome##";
            // 
            // btnIncluirPet
            // 
            this.btnIncluirPet.Location = new System.Drawing.Point(466, 458);
            this.btnIncluirPet.Name = "btnIncluirPet";
            this.btnIncluirPet.Size = new System.Drawing.Size(139, 47);
            this.btnIncluirPet.TabIndex = 18;
            this.btnIncluirPet.Text = "Incluir";
            this.btnIncluirPet.UseSelectable = true;
            this.btnIncluirPet.Click += new System.EventHandler(this.btnIncluirPet_Click);
            // 
            // ptbImagemPet
            // 
            this.ptbImagemPet.Location = new System.Drawing.Point(32, 31);
            this.ptbImagemPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbImagemPet.Name = "ptbImagemPet";
            this.ptbImagemPet.Size = new System.Drawing.Size(172, 187);
            this.ptbImagemPet.TabIndex = 9;
            this.ptbImagemPet.TabStop = false;
            // 
            // TelaPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnIncluirPet);
            this.Controls.Add(this.lblAvaliacaoPet);
            this.Controls.Add(this.lblGeneroPet);
            this.Controls.Add(this.lblTipoPet);
            this.Controls.Add(this.lblRacaPet);
            this.Controls.Add(this.lblNomePet);
            this.Controls.Add(this.ptbImagemPet);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPet";
            this.Text = "TelaPet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoPet;
        private System.Windows.Forms.Label lblAvaliacaoPet;
        private System.Windows.Forms.Label lblGeneroPet;
        private System.Windows.Forms.Label lblTipoPet;
        private System.Windows.Forms.Label lblRacaPet;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.PictureBox ptbImagemPet;
        private MetroFramework.Controls.MetroButton btnIncluirPet;
    }
}