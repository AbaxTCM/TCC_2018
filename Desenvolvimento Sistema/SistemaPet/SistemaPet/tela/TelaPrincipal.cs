using SistemaPet.dominio;
using SistemaPet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaPet.controlador.ControladorTelaLogin;

namespace SistemaPet.tela
{
    
    public partial class TelaPrincipal : Form
    {
        TelaPerfil telaPerfil = new TelaPerfil();

        
        public TelaPrincipal()
        {
            if (Session.Instance.Funcao == "Adestrador")
            {
                //NÃO CONSIGO SETAR A VISIBILIDADE AQUI DE ACORDO COM O PERFIL.
            }
            InitializeComponent();
            
        }
        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if(mpPainelMenu.Width == 215)
            {
                mpPainelMenu.Width = 61;
                btnMenu.Hide();
                pcbFecharMenu.Show();
                

            }
            else
            {
                mpPainelMenu.Width = 215;
                btnMenu.Hide();

            }
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbrestaurar.Visible = true;
        }

        private void pbrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbMaximizar.Visible = true;
            pbrestaurar.Visible = false;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnPerfil.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnPerfil.Image = Resources.user_silhouette;
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnPerfil.Image = Resources.user_silhouette_branco;
        }

        private void btnPets_MouseEnter(object sender, EventArgs e)
        {
            btnPets.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnPets.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnPets.Image = Resources.pet;
        }

        private void btnPets_MouseLeave(object sender, EventArgs e)
        {
            btnPets.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnPets.Image = Resources.pet_branco;
        }

        private void btnAdestradores_MouseEnter(object sender, EventArgs e)
        {
            btnAdestradores.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnAdestradores.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnAdestradores.Image = Resources.icon_handshake;
        }

        private void btnAdestradores_MouseLeave(object sender, EventArgs e)
        {
            btnAdestradores.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnAdestradores.Image = Resources.icon_handshake_branco;
        }

        private void btnComprar_MouseEnter(object sender, EventArgs e)
        {
            btnComprar.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnComprar.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnComprar.Image = Resources.shopping_cart;
        }

        private void btnComprar_MouseLeave(object sender, EventArgs e)
        {
            btnComprar.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnComprar.Image = Resources.shopping_cart_branco;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnSair.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnSair.Image = Resources.opened_door_aperture;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnSair.Image = Resources.opened_door_aperture_branco;
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.FromArgb(0, 148, 187, 27);
            btnCadastrar.ForeColor = Color.FromArgb(0, 16, 16, 16);
            btnCadastrar.Image = Resources.iconCadastrar;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnCadastrar.Image = Resources.iconCadastrarBranco;
        }

        #region Funcoes Formulario

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;


        // Método para arrastar a janela 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Fim método de arrastar Janela

        // -------------------------------

        // Método para dar Resize na janela, canto inferior
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.mpPainelConteudo.Region = region;
            this.Invalidate();
        }

        // -------------------------------

        // Método para quadrado no canto da tela
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        // Fim metodo

        // -------------------------------

        // Método para redimensionar e quadrado cinza
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }
        // Fim metodo

        // Evento de mover a Janela
        private void mpTopoMeio_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // Fim do Evento
        #endregion




        
        // Metodo para Abrir forms dentro do Painel
        private void AbrirFormnoPainel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = mpPainelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                mpPainelConteudo.Controls.Add(formulario);
                mpPainelConteudo.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }
        // Fim do metodo       

        private void btnPerfil_Click(object sender, EventArgs e)
        {
                AbrirFormnoPainel<TelaPerfil>();
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            AbrirFormnoPainel<TelaPet>();
        }

        private void mpTopoMeio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdestradores_Click(object sender, EventArgs e)
        {
            AbrirFormnoPainel<TelaAdestrador>();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormnoPainel<TelaCadastro>();
        }

        private void pcbFecharMenu_Click(object sender, EventArgs e)
        {
            mpPainelMenu.Width = 215;
            btnMenu.Show();
            pcbFecharMenu.Hide();
        }
    }
}