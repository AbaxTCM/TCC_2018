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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lklEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lklRegistrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(97, 178);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(97, 256);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 194);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(256, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(100, 272);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(256, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(192, 62);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(61, 13);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Bem-Vindo!";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(195, 338);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "button1";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lklEsqueciSenha
            // 
            this.lklEsqueciSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lklEsqueciSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(143)))));
            this.lklEsqueciSenha.AutoSize = true;
            this.lklEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(61)))));
            this.lklEsqueciSenha.Location = new System.Drawing.Point(97, 306);
            this.lklEsqueciSenha.Name = "lklEsqueciSenha";
            this.lklEsqueciSenha.Size = new System.Drawing.Size(86, 13);
            this.lklEsqueciSenha.TabIndex = 7;
            this.lklEsqueciSenha.TabStop = true;
            this.lklEsqueciSenha.Text = "Esqueci a senha";
            this.lklEsqueciSenha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(124)))));
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(169, 449);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(116, 13);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Precisa de uma conta?";
            // 
            // lklRegistrar
            // 
            this.lklRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lklRegistrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(143)))));
            this.lklRegistrar.AutoSize = true;
            this.lklRegistrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklRegistrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(61)))));
            this.lklRegistrar.Location = new System.Drawing.Point(291, 449);
            this.lklRegistrar.Name = "lklRegistrar";
            this.lklRegistrar.Size = new System.Drawing.Size(49, 13);
            this.lklRegistrar.TabIndex = 9;
            this.lklRegistrar.TabStop = true;
            this.lklRegistrar.Text = "Registrar";
            this.lklRegistrar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(124)))));
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(466, 532);
            this.Controls.Add(this.lklRegistrar);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lklEsqueciSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lklEsqueciSenha;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.LinkLabel lklRegistrar;
    }
}