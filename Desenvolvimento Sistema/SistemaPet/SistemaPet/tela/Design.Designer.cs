namespace SistemaPet.tela
{
    partial class Design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Design));
            this.msmEstiloMenu = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mpTopoMeio = new MetroFramework.Controls.MetroPanel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pbrestaurar = new System.Windows.Forms.PictureBox();
            this.mpPainelMenu = new MetroFramework.Controls.MetroPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAdestradores = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mpPainelConteudo = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.msmEstiloMenu)).BeginInit();
            this.mpTopoMeio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrestaurar)).BeginInit();
            this.mpPainelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msmEstiloMenu
            // 
            this.msmEstiloMenu.Owner = null;
            // 
            // mpTopoMeio
            // 
            this.mpTopoMeio.BackColor = System.Drawing.Color.White;
            this.mpTopoMeio.Controls.Add(this.pbMinimizar);
            this.mpTopoMeio.Controls.Add(this.pbMaximizar);
            this.mpTopoMeio.Controls.Add(this.pbFechar);
            this.mpTopoMeio.Controls.Add(this.btnMenu);
            this.mpTopoMeio.Controls.Add(this.pbrestaurar);
            this.mpTopoMeio.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpTopoMeio.HorizontalScrollbarBarColor = true;
            this.mpTopoMeio.HorizontalScrollbarHighlightOnWheel = false;
            this.mpTopoMeio.HorizontalScrollbarSize = 10;
            this.mpTopoMeio.Location = new System.Drawing.Point(215, 0);
            this.mpTopoMeio.Name = "mpTopoMeio";
            this.mpTopoMeio.Size = new System.Drawing.Size(969, 60);
            this.mpTopoMeio.TabIndex = 2;
            this.mpTopoMeio.UseCustomBackColor = true;
            this.mpTopoMeio.UseCustomForeColor = true;
            this.mpTopoMeio.UseStyleColors = true;
            this.mpTopoMeio.VerticalScrollbarBarColor = true;
            this.mpTopoMeio.VerticalScrollbarHighlightOnWheel = false;
            this.mpTopoMeio.VerticalScrollbarSize = 10;
            this.mpTopoMeio.Paint += new System.Windows.Forms.PaintEventHandler(this.mpTopoMeio_Paint);
            this.mpTopoMeio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mpTopoMeio_MouseMove);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(830, 3);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(41, 41);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 3;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(877, 3);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(41, 41);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 4;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = ((System.Drawing.Image)(resources.GetObject("pbFechar.Image")));
            this.pbFechar.Location = new System.Drawing.Point(925, 3);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(41, 41);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechar.TabIndex = 2;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(6, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pbrestaurar
            // 
            this.pbrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbrestaurar.Image")));
            this.pbrestaurar.Location = new System.Drawing.Point(877, 3);
            this.pbrestaurar.Name = "pbrestaurar";
            this.pbrestaurar.Size = new System.Drawing.Size(41, 41);
            this.pbrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbrestaurar.TabIndex = 3;
            this.pbrestaurar.TabStop = false;
            this.pbrestaurar.Click += new System.EventHandler(this.pbrestaurar_Click);
            // 
            // mpPainelMenu
            // 
            this.mpPainelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mpPainelMenu.Controls.Add(this.btnSair);
            this.mpPainelMenu.Controls.Add(this.btnComprar);
            this.mpPainelMenu.Controls.Add(this.btnAdestradores);
            this.mpPainelMenu.Controls.Add(this.btnPets);
            this.mpPainelMenu.Controls.Add(this.btnPerfil);
            this.mpPainelMenu.Controls.Add(this.pictureBox1);
            this.mpPainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpPainelMenu.HorizontalScrollbarBarColor = true;
            this.mpPainelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mpPainelMenu.HorizontalScrollbarSize = 10;
            this.mpPainelMenu.Location = new System.Drawing.Point(0, 0);
            this.mpPainelMenu.Name = "mpPainelMenu";
            this.mpPainelMenu.Size = new System.Drawing.Size(215, 634);
            this.mpPainelMenu.TabIndex = 4;
            this.mpPainelMenu.UseCustomBackColor = true;
            this.mpPainelMenu.UseCustomForeColor = true;
            this.mpPainelMenu.UseStyleColors = true;
            this.mpPainelMenu.VerticalScrollbarBarColor = true;
            this.mpPainelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mpPainelMenu.VerticalScrollbarSize = 10;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Image = global::SistemaPet.Properties.Resources.opened_door_aperture_branco;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 559);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(210, 55);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnComprar
            // 
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnComprar.Image = global::SistemaPet.Properties.Resources.shopping_cart_branco;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(0, 345);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(210, 55);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.MouseEnter += new System.EventHandler(this.btnComprar_MouseEnter);
            this.btnComprar.MouseLeave += new System.EventHandler(this.btnComprar_MouseLeave);
            // 
            // btnAdestradores
            // 
            this.btnAdestradores.FlatAppearance.BorderSize = 0;
            this.btnAdestradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdestradores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdestradores.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdestradores.Image = global::SistemaPet.Properties.Resources.icon_handshake_branco;
            this.btnAdestradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdestradores.Location = new System.Drawing.Point(0, 274);
            this.btnAdestradores.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdestradores.Name = "btnAdestradores";
            this.btnAdestradores.Size = new System.Drawing.Size(210, 55);
            this.btnAdestradores.TabIndex = 3;
            this.btnAdestradores.Text = "     ADESTRADORES";
            this.btnAdestradores.UseVisualStyleBackColor = true;
            this.btnAdestradores.Click += new System.EventHandler(this.btnAdestradores_Click);
            this.btnAdestradores.MouseEnter += new System.EventHandler(this.btnAdestradores_MouseEnter);
            this.btnAdestradores.MouseLeave += new System.EventHandler(this.btnAdestradores_MouseLeave);
            // 
            // btnPets
            // 
            this.btnPets.FlatAppearance.BorderSize = 0;
            this.btnPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPets.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPets.Image = global::SistemaPet.Properties.Resources.pet_branco;
            this.btnPets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPets.Location = new System.Drawing.Point(0, 199);
            this.btnPets.Margin = new System.Windows.Forms.Padding(2);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(210, 55);
            this.btnPets.TabIndex = 2;
            this.btnPets.Text = "MEUS PETS";
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            this.btnPets.MouseEnter += new System.EventHandler(this.btnPets_MouseEnter);
            this.btnPets.MouseLeave += new System.EventHandler(this.btnPets_MouseLeave);
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPerfil.Image = global::SistemaPet.Properties.Resources.user_silhouette_branco;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(2, 129);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(210, 55);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            this.btnPerfil.MouseEnter += new System.EventHandler(this.btnPerfil_MouseEnter);
            this.btnPerfil.MouseLeave += new System.EventHandler(this.btnPerfil_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mpPainelConteudo
            // 
            this.mpPainelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpPainelConteudo.HorizontalScrollbarBarColor = true;
            this.mpPainelConteudo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpPainelConteudo.HorizontalScrollbarSize = 10;
            this.mpPainelConteudo.Location = new System.Drawing.Point(215, 60);
            this.mpPainelConteudo.Name = "mpPainelConteudo";
            this.mpPainelConteudo.Size = new System.Drawing.Size(969, 574);
            this.mpPainelConteudo.TabIndex = 5;
            this.mpPainelConteudo.VerticalScrollbarBarColor = true;
            this.mpPainelConteudo.VerticalScrollbarHighlightOnWheel = false;
            this.mpPainelConteudo.VerticalScrollbarSize = 10;
            // 
            // Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1184, 634);
            this.ControlBox = false;
            this.Controls.Add(this.mpPainelConteudo);
            this.Controls.Add(this.mpTopoMeio);
            this.Controls.Add(this.mpPainelMenu);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Design";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.msmEstiloMenu)).EndInit();
            this.mpTopoMeio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrestaurar)).EndInit();
            this.mpPainelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager msmEstiloMenu;
        private MetroFramework.Controls.MetroPanel mpTopoMeio;
        private MetroFramework.Controls.MetroPanel mpPainelMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private MetroFramework.Controls.MetroPanel mpPainelConteudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.PictureBox pbrestaurar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnAdestradores;
        private System.Windows.Forms.Button btnPets;
        private System.Windows.Forms.Button btnPerfil;
    }
}