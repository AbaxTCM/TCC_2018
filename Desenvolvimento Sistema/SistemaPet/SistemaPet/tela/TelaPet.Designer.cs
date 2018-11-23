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
            this.txtIdPet = new System.Windows.Forms.TextBox();
            this.lblIdPet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRacaPet = new System.Windows.Forms.TextBox();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.mtbTrocarImagemPet = new MetroFramework.Controls.MetroButton();
            this.lblAvaliacaoPet = new System.Windows.Forms.Label();
            this.lblGeneroPet = new System.Windows.Forms.Label();
            this.lblRacaPet = new System.Windows.Forms.Label();
            this.lblTipoPet = new System.Windows.Forms.Label();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.ptbImagemPet = new System.Windows.Forms.PictureBox();
            this.btnAlterarPet = new MetroFramework.Controls.MetroButton();
            this.btnSalvarPet = new MetroFramework.Controls.MetroButton();
            this.rtbAvaliacaoPet = new System.Windows.Forms.RichTextBox();
            this.btnMeusPets = new MetroFramework.Controls.MetroButton();
            this.cmbTipoPet = new MetroFramework.Controls.MetroComboBox();
            this.cmbGeneroPet = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemPet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPet
            // 
            this.txtIdPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdPet.Location = new System.Drawing.Point(384, 85);
            this.txtIdPet.Name = "txtIdPet";
            this.txtIdPet.ReadOnly = true;
            this.txtIdPet.Size = new System.Drawing.Size(256, 26);
            this.txtIdPet.TabIndex = 49;
            // 
            // lblIdPet
            // 
            this.lblIdPet.AutoSize = true;
            this.lblIdPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIdPet.Location = new System.Drawing.Point(323, 93);
            this.lblIdPet.Name = "lblIdPet";
            this.lblIdPet.Size = new System.Drawing.Size(58, 20);
            this.lblIdPet.TabIndex = 48;
            this.lblIdPet.Text = "ID Pet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(369, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Dados Cadastrais :";
            // 
            // txtRacaPet
            // 
            this.txtRacaPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRacaPet.Location = new System.Drawing.Point(400, 186);
            this.txtRacaPet.Name = "txtRacaPet";
            this.txtRacaPet.ReadOnly = true;
            this.txtRacaPet.Size = new System.Drawing.Size(240, 26);
            this.txtRacaPet.TabIndex = 41;
            // 
            // txtNomePet
            // 
            this.txtNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomePet.Location = new System.Drawing.Point(384, 118);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.ReadOnly = true;
            this.txtNomePet.Size = new System.Drawing.Size(256, 26);
            this.txtNomePet.TabIndex = 39;
            // 
            // mtbTrocarImagemPet
            // 
            this.mtbTrocarImagemPet.DisplayFocus = true;
            this.mtbTrocarImagemPet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbTrocarImagemPet.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mtbTrocarImagemPet.Location = new System.Drawing.Point(159, 227);
            this.mtbTrocarImagemPet.Name = "mtbTrocarImagemPet";
            this.mtbTrocarImagemPet.Size = new System.Drawing.Size(129, 23);
            this.mtbTrocarImagemPet.TabIndex = 38;
            this.mtbTrocarImagemPet.Text = "Alterar Imagem";
            this.mtbTrocarImagemPet.UseSelectable = true;
            // 
            // lblAvaliacaoPet
            // 
            this.lblAvaliacaoPet.AutoSize = true;
            this.lblAvaliacaoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAvaliacaoPet.Location = new System.Drawing.Point(168, 328);
            this.lblAvaliacaoPet.Name = "lblAvaliacaoPet";
            this.lblAvaliacaoPet.Size = new System.Drawing.Size(81, 20);
            this.lblAvaliacaoPet.TabIndex = 35;
            this.lblAvaliacaoPet.Text = "Avaliação:";
            // 
            // lblGeneroPet
            // 
            this.lblGeneroPet.AutoSize = true;
            this.lblGeneroPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGeneroPet.Location = new System.Drawing.Point(168, 273);
            this.lblGeneroPet.Name = "lblGeneroPet";
            this.lblGeneroPet.Size = new System.Drawing.Size(67, 20);
            this.lblGeneroPet.TabIndex = 33;
            this.lblGeneroPet.Text = "Genero:";
            // 
            // lblRacaPet
            // 
            this.lblRacaPet.AutoSize = true;
            this.lblRacaPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRacaPet.Location = new System.Drawing.Point(323, 192);
            this.lblRacaPet.Name = "lblRacaPet";
            this.lblRacaPet.Size = new System.Drawing.Size(51, 20);
            this.lblRacaPet.TabIndex = 32;
            this.lblRacaPet.Text = "Raça:";
            // 
            // lblTipoPet
            // 
            this.lblTipoPet.AutoSize = true;
            this.lblTipoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPet.Location = new System.Drawing.Point(323, 158);
            this.lblTipoPet.Name = "lblTipoPet";
            this.lblTipoPet.Size = new System.Drawing.Size(43, 20);
            this.lblTipoPet.TabIndex = 31;
            this.lblTipoPet.Text = "Tipo:";
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomePet.Location = new System.Drawing.Point(323, 126);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(55, 20);
            this.lblNomePet.TabIndex = 30;
            this.lblNomePet.Text = "Nome:";
            // 
            // ptbImagemPet
            // 
            this.ptbImagemPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagemPet.Location = new System.Drawing.Point(159, 70);
            this.ptbImagemPet.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImagemPet.Name = "ptbImagemPet";
            this.ptbImagemPet.Size = new System.Drawing.Size(129, 152);
            this.ptbImagemPet.TabIndex = 29;
            this.ptbImagemPet.TabStop = false;
            // 
            // btnAlterarPet
            // 
            this.btnAlterarPet.Location = new System.Drawing.Point(317, 471);
            this.btnAlterarPet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarPet.Name = "btnAlterarPet";
            this.btnAlterarPet.Size = new System.Drawing.Size(104, 38);
            this.btnAlterarPet.TabIndex = 50;
            this.btnAlterarPet.Text = "ALTERAR";
            this.btnAlterarPet.UseSelectable = true;
            this.btnAlterarPet.Click += new System.EventHandler(this.btnAlterarPet_Click);
            // 
            // btnSalvarPet
            // 
            this.btnSalvarPet.Location = new System.Drawing.Point(317, 471);
            this.btnSalvarPet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarPet.Name = "btnSalvarPet";
            this.btnSalvarPet.Size = new System.Drawing.Size(104, 38);
            this.btnSalvarPet.TabIndex = 51;
            this.btnSalvarPet.Text = "SALVAR";
            this.btnSalvarPet.UseSelectable = true;
            this.btnSalvarPet.Visible = false;
            this.btnSalvarPet.Click += new System.EventHandler(this.btnSalvarPet_Click);
            // 
            // rtbAvaliacaoPet
            // 
            this.rtbAvaliacaoPet.Location = new System.Drawing.Point(247, 331);
            this.rtbAvaliacaoPet.Margin = new System.Windows.Forms.Padding(2);
            this.rtbAvaliacaoPet.Name = "rtbAvaliacaoPet";
            this.rtbAvaliacaoPet.ReadOnly = true;
            this.rtbAvaliacaoPet.Size = new System.Drawing.Size(461, 101);
            this.rtbAvaliacaoPet.TabIndex = 52;
            this.rtbAvaliacaoPet.Text = "";
            // 
            // btnMeusPets
            // 
            this.btnMeusPets.Location = new System.Drawing.Point(428, 471);
            this.btnMeusPets.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeusPets.Name = "btnMeusPets";
            this.btnMeusPets.Size = new System.Drawing.Size(104, 38);
            this.btnMeusPets.TabIndex = 53;
            this.btnMeusPets.Text = "MEUS PETS";
            this.btnMeusPets.UseSelectable = true;
            this.btnMeusPets.Click += new System.EventHandler(this.btnMeusPets_Click);
            // 
            // cmbTipoPet
            // 
            this.cmbTipoPet.AutoCompleteCustomSource.AddRange(new string[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cmbTipoPet.Enabled = false;
            this.cmbTipoPet.FormattingEnabled = true;
            this.cmbTipoPet.ItemHeight = 23;
            this.cmbTipoPet.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cmbTipoPet.Location = new System.Drawing.Point(400, 149);
            this.cmbTipoPet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPet.Name = "cmbTipoPet";
            this.cmbTipoPet.Size = new System.Drawing.Size(240, 29);
            this.cmbTipoPet.TabIndex = 56;
            this.cmbTipoPet.UseSelectable = true;
            // 
            // cmbGeneroPet
            // 
            this.cmbGeneroPet.AutoCompleteCustomSource.AddRange(new string[] {
            "Fêmea",
            "Macho"});
            this.cmbGeneroPet.Enabled = false;
            this.cmbGeneroPet.FormattingEnabled = true;
            this.cmbGeneroPet.ItemHeight = 23;
            this.cmbGeneroPet.Items.AddRange(new object[] {
            "Fêmea",
            "Macho"});
            this.cmbGeneroPet.Location = new System.Drawing.Point(247, 267);
            this.cmbGeneroPet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGeneroPet.Name = "cmbGeneroPet";
            this.cmbGeneroPet.Size = new System.Drawing.Size(240, 29);
            this.cmbGeneroPet.TabIndex = 57;
            this.cmbGeneroPet.UseSelectable = true;
            // 
            // TelaPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Controls.Add(this.cmbGeneroPet);
            this.Controls.Add(this.cmbTipoPet);
            this.Controls.Add(this.btnMeusPets);
            this.Controls.Add(this.rtbAvaliacaoPet);
            this.Controls.Add(this.btnAlterarPet);
            this.Controls.Add(this.btnSalvarPet);
            this.Controls.Add(this.txtIdPet);
            this.Controls.Add(this.lblIdPet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRacaPet);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.mtbTrocarImagemPet);
            this.Controls.Add(this.lblAvaliacaoPet);
            this.Controls.Add(this.lblGeneroPet);
            this.Controls.Add(this.lblRacaPet);
            this.Controls.Add(this.lblTipoPet);
            this.Controls.Add(this.lblNomePet);
            this.Controls.Add(this.ptbImagemPet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPet";
            this.Text = "TelaPet";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPet;
        private System.Windows.Forms.Label lblIdPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRacaPet;
        private System.Windows.Forms.TextBox txtNomePet;
        private MetroFramework.Controls.MetroButton mtbTrocarImagemPet;
        private System.Windows.Forms.Label lblAvaliacaoPet;
        private System.Windows.Forms.Label lblGeneroPet;
        private System.Windows.Forms.Label lblRacaPet;
        private System.Windows.Forms.Label lblTipoPet;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.PictureBox ptbImagemPet;
        private MetroFramework.Controls.MetroButton btnAlterarPet;
        private MetroFramework.Controls.MetroButton btnSalvarPet;
        private System.Windows.Forms.RichTextBox rtbAvaliacaoPet;
        private MetroFramework.Controls.MetroButton btnMeusPets;
        private MetroFramework.Controls.MetroComboBox cmbTipoPet;
        private MetroFramework.Controls.MetroComboBox cmbGeneroPet;
    }
}