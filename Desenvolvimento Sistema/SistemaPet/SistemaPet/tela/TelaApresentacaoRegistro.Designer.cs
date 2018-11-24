namespace SistemaPet.tela
{
    partial class TelaApresentacaoRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaApresentacaoRegistro));
            this.lblCadastroAdestrador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDonoCadastro = new System.Windows.Forms.Button();
            this.btnAdestradorCadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastroAdestrador
            // 
            this.lblCadastroAdestrador.AutoSize = true;
            this.lblCadastroAdestrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCadastroAdestrador.Location = new System.Drawing.Point(77, 9);
            this.lblCadastroAdestrador.Name = "lblCadastroAdestrador";
            this.lblCadastroAdestrador.Size = new System.Drawing.Size(363, 31);
            this.lblCadastroAdestrador.TabIndex = 75;
            this.lblCadastroAdestrador.Text = "Bem Vindo ao nosso sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "Qual tipo de Cadastro deseja realizar?";
            // 
            // btnDonoCadastro
            // 
            this.btnDonoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDonoCadastro.FlatAppearance.BorderSize = 0;
            this.btnDonoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonoCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDonoCadastro.Image = global::SistemaPet.Properties.Resources.user_silhouette_branco;
            this.btnDonoCadastro.Location = new System.Drawing.Point(0, -1);
            this.btnDonoCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnDonoCadastro.Name = "btnDonoCadastro";
            this.btnDonoCadastro.Size = new System.Drawing.Size(237, 100);
            this.btnDonoCadastro.TabIndex = 77;
            this.btnDonoCadastro.Text = "DONO";
            this.btnDonoCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonoCadastro.UseVisualStyleBackColor = false;
            this.btnDonoCadastro.Click += new System.EventHandler(this.btnDonoCadastro_Click);
            this.btnDonoCadastro.MouseEnter += new System.EventHandler(this.btnDonoCadastro_MouseEnter);
            this.btnDonoCadastro.MouseLeave += new System.EventHandler(this.btnDonoCadastro_MouseLeave);
            // 
            // btnAdestradorCadastro
            // 
            this.btnAdestradorCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdestradorCadastro.FlatAppearance.BorderSize = 0;
            this.btnAdestradorCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdestradorCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdestradorCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdestradorCadastro.Image = global::SistemaPet.Properties.Resources.user_silhouette_branco;
            this.btnAdestradorCadastro.Location = new System.Drawing.Point(275, -1);
            this.btnAdestradorCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdestradorCadastro.Name = "btnAdestradorCadastro";
            this.btnAdestradorCadastro.Size = new System.Drawing.Size(237, 100);
            this.btnAdestradorCadastro.TabIndex = 78;
            this.btnAdestradorCadastro.Text = "ADESTRADOR";
            this.btnAdestradorCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdestradorCadastro.UseVisualStyleBackColor = false;
            this.btnAdestradorCadastro.Click += new System.EventHandler(this.btnAdestradorCadastro_Click);
            this.btnAdestradorCadastro.MouseEnter += new System.EventHandler(this.btnAdestradorCadastro_MouseEnter);
            this.btnAdestradorCadastro.MouseLeave += new System.EventHandler(this.btnAdestradorCadastro_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnAdestradorCadastro);
            this.panel1.Controls.Add(this.btnDonoCadastro);
            this.panel1.Location = new System.Drawing.Point(-1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 99);
            this.panel1.TabIndex = 79;
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = ((System.Drawing.Image)(resources.GetObject("pbFechar.Image")));
            this.pbFechar.Location = new System.Drawing.Point(466, 3);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(41, 41);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechar.TabIndex = 80;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // TelaApresentacaoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(510, 177);
            this.Controls.Add(this.pbFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCadastroAdestrador);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaApresentacaoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaApresentacaoRegistro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroAdestrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonoCadastro;
        private System.Windows.Forms.Button btnAdestradorCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFechar;
    }
}