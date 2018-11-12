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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lklEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lklRegistrar = new System.Windows.Forms.LinkLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mbcTelaLogin = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mbcTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.lblLogin.Location = new System.Drawing.Point(95, 166);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 19);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.lblSenha.Location = new System.Drawing.Point(96, 250);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 19);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.txtLogin.Location = new System.Drawing.Point(100, 194);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(256, 27);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.txtSenha.Location = new System.Drawing.Point(100, 272);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(256, 27);
            this.txtSenha.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(167, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 25);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Bem-Vindo !";
            // 
            // lklEsqueciSenha
            // 
            this.lklEsqueciSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lklEsqueciSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(143)))));
            this.lklEsqueciSenha.AutoSize = true;
            this.lklEsqueciSenha.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.lklEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(61)))));
            this.lklEsqueciSenha.Location = new System.Drawing.Point(95, 302);
            this.lklEsqueciSenha.Name = "lklEsqueciSenha";
            this.lklEsqueciSenha.Size = new System.Drawing.Size(118, 19);
            this.lklEsqueciSenha.TabIndex = 7;
            this.lklEsqueciSenha.TabStop = true;
            this.lklEsqueciSenha.Text = "Esqueci a senha";
            this.lklEsqueciSenha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(124)))));
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.lblRegistro.Location = new System.Drawing.Point(139, 457);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(163, 19);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Precisa de uma conta?";
            // 
            // lklRegistrar
            // 
            this.lklRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lklRegistrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(143)))));
            this.lklRegistrar.AutoSize = true;
            this.lklRegistrar.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.lklRegistrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklRegistrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(61)))));
            this.lklRegistrar.Location = new System.Drawing.Point(187, 476);
            this.lklRegistrar.Name = "lklRegistrar";
            this.lklRegistrar.Size = new System.Drawing.Size(72, 19);
            this.lklRegistrar.TabIndex = 9;
            this.lklRegistrar.TabStop = true;
            this.lklRegistrar.Text = "Registrar";
            this.lklRegistrar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(124)))));
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(184, 372);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Entrar";
            this.metroButton1.UseSelectable = true;
            // 
            // mbcTelaLogin
            // 
            this.mbcTelaLogin.Owner = this;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 532);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lklRegistrar);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lklEsqueciSenha);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Name = "TelaLogin";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mbcTelaLogin)).EndInit();
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
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager mbcTelaLogin;
    }
}