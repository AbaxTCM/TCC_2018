namespace SistemaPet.tela
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lklEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lklRegistrar = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.mbcTelaLogin = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pbFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mbcTelaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogin.Location = new System.Drawing.Point(127, 204);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(66, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenha.Location = new System.Drawing.Point(128, 308);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 25);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLogin.Location = new System.Drawing.Point(133, 239);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(340, 30);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenha.Location = new System.Drawing.Point(133, 335);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(340, 30);
            this.txtSenha.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(223, 74);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(162, 31);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Bem-Vindo !";
            // 
            // lklEsqueciSenha
            // 
            this.lklEsqueciSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lklEsqueciSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(143)))));
            this.lklEsqueciSenha.AutoSize = true;
            this.lklEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lklEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(61)))));
            this.lklEsqueciSenha.Location = new System.Drawing.Point(127, 372);
            this.lklEsqueciSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklEsqueciSenha.Name = "lklEsqueciSenha";
            this.lklEsqueciSenha.Size = new System.Drawing.Size(157, 25);
            this.lklEsqueciSenha.TabIndex = 4;
            this.lklEsqueciSenha.TabStop = true;
            this.lklEsqueciSenha.Text = "Esqueci a senha";
            this.lklEsqueciSenha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(124)))));
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistro.Location = new System.Drawing.Point(185, 562);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(211, 25);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Precisa de uma conta?";
            // 
            // lklRegistrar
            // 
            this.lklRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lklRegistrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(143)))));
            this.lklRegistrar.AutoSize = true;
            this.lklRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lklRegistrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklRegistrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(61)))));
            this.lklRegistrar.Location = new System.Drawing.Point(249, 586);
            this.lklRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklRegistrar.Name = "lklRegistrar";
            this.lklRegistrar.Size = new System.Drawing.Size(89, 25);
            this.lklRegistrar.TabIndex = 5;
            this.lklRegistrar.TabStop = true;
            this.lklRegistrar.Text = "Registrar";
            this.lklRegistrar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(124)))));
            this.lklRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRegistrar_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.DisplayFocus = true;
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEntrar.Location = new System.Drawing.Point(245, 458);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(100, 28);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // mbcTelaLogin
            // 
            this.mbcTelaLogin.Owner = this;
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = ((System.Drawing.Image)(resources.GetObject("pbFechar.Image")));
            this.pbFechar.Location = new System.Drawing.Point(557, 12);
            this.pbFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(55, 50);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechar.TabIndex = 11;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 655);
            this.ControlBox = false;
            this.Controls.Add(this.pbFechar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lklRegistrar);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lklEsqueciSenha);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaLogin";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mbcTelaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel lklEsqueciSenha;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.LinkLabel lklRegistrar;
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Components.MetroStyleManager mbcTelaLogin;
        private System.Windows.Forms.PictureBox pbFechar;
    }
}