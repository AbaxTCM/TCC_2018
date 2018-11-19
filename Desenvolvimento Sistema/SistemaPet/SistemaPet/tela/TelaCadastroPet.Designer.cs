namespace SistemaPet.tela
{
    partial class TelaCadastroPet
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
            this.btnCancelarPet = new MetroFramework.Controls.MetroButton();
            this.btnSalvarPet = new MetroFramework.Controls.MetroButton();
            this.lblRacaPet = new MetroFramework.Controls.MetroLabel();
            this.txtRacaPet = new MetroFramework.Controls.MetroTextBox();
            this.lblNomePet = new MetroFramework.Controls.MetroLabel();
            this.txtNomePet = new MetroFramework.Controls.MetroTextBox();
            this.pnlCadastroPet = new System.Windows.Forms.Panel();
            this.cmbTipoPet = new MetroFramework.Controls.MetroComboBox();
            this.gbxGeneroPet = new System.Windows.Forms.GroupBox();
            this.rbnMacho = new MetroFramework.Controls.MetroRadioButton();
            this.rbnFemea = new MetroFramework.Controls.MetroRadioButton();
            this.lblTipoPet = new MetroFramework.Controls.MetroLabel();
            this.lblCadastroPet = new System.Windows.Forms.Label();
            this.pnlCadastroPet.SuspendLayout();
            this.gbxGeneroPet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarPet
            // 
            this.btnCancelarPet.Location = new System.Drawing.Point(603, 455);
            this.btnCancelarPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarPet.Name = "btnCancelarPet";
            this.btnCancelarPet.Size = new System.Drawing.Size(139, 47);
            this.btnCancelarPet.TabIndex = 22;
            this.btnCancelarPet.Text = "CANCELAR";
            this.btnCancelarPet.UseSelectable = true;
            this.btnCancelarPet.Click += new System.EventHandler(this.btnCancelarPet_Click);
            // 
            // btnSalvarPet
            // 
            this.btnSalvarPet.Location = new System.Drawing.Point(337, 455);
            this.btnSalvarPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarPet.Name = "btnSalvarPet";
            this.btnSalvarPet.Size = new System.Drawing.Size(139, 47);
            this.btnSalvarPet.TabIndex = 21;
            this.btnSalvarPet.Text = "SALVAR";
            this.btnSalvarPet.UseSelectable = true;
            this.btnSalvarPet.Click += new System.EventHandler(this.btnSalvarPet_Click);
            // 
            // lblRacaPet
            // 
            this.lblRacaPet.AutoSize = true;
            this.lblRacaPet.Location = new System.Drawing.Point(221, 142);
            this.lblRacaPet.Name = "lblRacaPet";
            this.lblRacaPet.Size = new System.Drawing.Size(41, 20);
            this.lblRacaPet.TabIndex = 17;
            this.lblRacaPet.Text = "Raça:";
            // 
            // txtRacaPet
            // 
            // 
            // 
            // 
            this.txtRacaPet.CustomButton.Image = null;
            this.txtRacaPet.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtRacaPet.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRacaPet.CustomButton.Name = "";
            this.txtRacaPet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRacaPet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRacaPet.CustomButton.TabIndex = 1;
            this.txtRacaPet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRacaPet.CustomButton.UseSelectable = true;
            this.txtRacaPet.CustomButton.Visible = false;
            this.txtRacaPet.Lines = new string[0];
            this.txtRacaPet.Location = new System.Drawing.Point(249, 166);
            this.txtRacaPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRacaPet.MaxLength = 32767;
            this.txtRacaPet.Name = "txtRacaPet";
            this.txtRacaPet.PasswordChar = '\0';
            this.txtRacaPet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRacaPet.SelectedText = "";
            this.txtRacaPet.SelectionLength = 0;
            this.txtRacaPet.SelectionStart = 0;
            this.txtRacaPet.ShortcutsEnabled = true;
            this.txtRacaPet.Size = new System.Drawing.Size(285, 23);
            this.txtRacaPet.TabIndex = 15;
            this.txtRacaPet.UseSelectable = true;
            this.txtRacaPet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRacaPet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Location = new System.Drawing.Point(221, 70);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(51, 20);
            this.lblNomePet.TabIndex = 16;
            this.lblNomePet.Text = "Nome:";
            // 
            // txtNomePet
            // 
            // 
            // 
            // 
            this.txtNomePet.CustomButton.Image = null;
            this.txtNomePet.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtNomePet.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNomePet.CustomButton.Name = "";
            this.txtNomePet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomePet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomePet.CustomButton.TabIndex = 1;
            this.txtNomePet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomePet.CustomButton.UseSelectable = true;
            this.txtNomePet.CustomButton.Visible = false;
            this.txtNomePet.Lines = new string[0];
            this.txtNomePet.Location = new System.Drawing.Point(249, 95);
            this.txtNomePet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePet.MaxLength = 32767;
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.PasswordChar = '\0';
            this.txtNomePet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomePet.SelectedText = "";
            this.txtNomePet.SelectionLength = 0;
            this.txtNomePet.SelectionStart = 0;
            this.txtNomePet.ShortcutsEnabled = true;
            this.txtNomePet.Size = new System.Drawing.Size(285, 23);
            this.txtNomePet.TabIndex = 14;
            this.txtNomePet.UseSelectable = true;
            this.txtNomePet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomePet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlCadastroPet
            // 
            this.pnlCadastroPet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCadastroPet.Controls.Add(this.cmbTipoPet);
            this.pnlCadastroPet.Controls.Add(this.gbxGeneroPet);
            this.pnlCadastroPet.Controls.Add(this.txtNomePet);
            this.pnlCadastroPet.Controls.Add(this.btnCancelarPet);
            this.pnlCadastroPet.Controls.Add(this.lblNomePet);
            this.pnlCadastroPet.Controls.Add(this.btnSalvarPet);
            this.pnlCadastroPet.Controls.Add(this.txtRacaPet);
            this.pnlCadastroPet.Controls.Add(this.lblTipoPet);
            this.pnlCadastroPet.Controls.Add(this.lblRacaPet);
            this.pnlCadastroPet.Location = new System.Drawing.Point(12, 141);
            this.pnlCadastroPet.Name = "pnlCadastroPet";
            this.pnlCadastroPet.Size = new System.Drawing.Size(1096, 560);
            this.pnlCadastroPet.TabIndex = 24;
            // 
            // cmbTipoPet
            // 
            this.cmbTipoPet.FormattingEnabled = true;
            this.cmbTipoPet.ItemHeight = 24;
            this.cmbTipoPet.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cmbTipoPet.Location = new System.Drawing.Point(251, 239);
            this.cmbTipoPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoPet.Name = "cmbTipoPet";
            this.cmbTipoPet.Size = new System.Drawing.Size(121, 30);
            this.cmbTipoPet.TabIndex = 25;
            this.cmbTipoPet.UseSelectable = true;
            // 
            // gbxGeneroPet
            // 
            this.gbxGeneroPet.Controls.Add(this.rbnMacho);
            this.gbxGeneroPet.Controls.Add(this.rbnFemea);
            this.gbxGeneroPet.Location = new System.Drawing.Point(634, 95);
            this.gbxGeneroPet.Name = "gbxGeneroPet";
            this.gbxGeneroPet.Size = new System.Drawing.Size(111, 136);
            this.gbxGeneroPet.TabIndex = 24;
            this.gbxGeneroPet.TabStop = false;
            this.gbxGeneroPet.Text = "Gênero:";
            // 
            // rbnMacho
            // 
            this.rbnMacho.AutoSize = true;
            this.rbnMacho.Location = new System.Drawing.Point(22, 81);
            this.rbnMacho.Name = "rbnMacho";
            this.rbnMacho.Size = new System.Drawing.Size(64, 17);
            this.rbnMacho.TabIndex = 1;
            this.rbnMacho.Text = "Macho";
            this.rbnMacho.UseSelectable = true;
            // 
            // rbnFemea
            // 
            this.rbnFemea.AutoSize = true;
            this.rbnFemea.Location = new System.Drawing.Point(22, 43);
            this.rbnFemea.Name = "rbnFemea";
            this.rbnFemea.Size = new System.Drawing.Size(62, 17);
            this.rbnFemea.TabIndex = 0;
            this.rbnFemea.Text = "Fêmea";
            this.rbnFemea.UseSelectable = true;
            // 
            // lblTipoPet
            // 
            this.lblTipoPet.AutoSize = true;
            this.lblTipoPet.Location = new System.Drawing.Point(221, 215);
            this.lblTipoPet.Name = "lblTipoPet";
            this.lblTipoPet.Size = new System.Drawing.Size(39, 20);
            this.lblTipoPet.TabIndex = 23;
            this.lblTipoPet.Text = "Tipo:";
            // 
            // lblCadastroPet
            // 
            this.lblCadastroPet.AutoSize = true;
            this.lblCadastroPet.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroPet.Location = new System.Drawing.Point(477, 48);
            this.lblCadastroPet.Name = "lblCadastroPet";
            this.lblCadastroPet.Size = new System.Drawing.Size(160, 35);
            this.lblCadastroPet.TabIndex = 25;
            this.lblCadastroPet.Text = "Cadastro Pet";
            // 
            // TelaCadastroPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 662);
            this.Controls.Add(this.lblCadastroPet);
            this.Controls.Add(this.pnlCadastroPet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadastroPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroPet";
            this.pnlCadastroPet.ResumeLayout(false);
            this.pnlCadastroPet.PerformLayout();
            this.gbxGeneroPet.ResumeLayout(false);
            this.gbxGeneroPet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancelarPet;
        private MetroFramework.Controls.MetroButton btnSalvarPet;
        private MetroFramework.Controls.MetroLabel lblRacaPet;
        private MetroFramework.Controls.MetroTextBox txtRacaPet;
        private MetroFramework.Controls.MetroLabel lblNomePet;
        private MetroFramework.Controls.MetroTextBox txtNomePet;
        private System.Windows.Forms.Panel pnlCadastroPet;
        private System.Windows.Forms.Label lblCadastroPet;
        private System.Windows.Forms.GroupBox gbxGeneroPet;
        private MetroFramework.Controls.MetroRadioButton rbnMacho;
        private MetroFramework.Controls.MetroRadioButton rbnFemea;
        private MetroFramework.Controls.MetroComboBox cmbTipoPet;
        private MetroFramework.Controls.MetroLabel lblTipoPet;
    }
}