using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.tela
{
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
           
        }

        Conexao conn = new Conexao();
        private void TelaLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void lklRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroUsuario cadastro2 = new TelaCadastroUsuario();
            cadastro2.Show();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string[] query;
            query = new string[2];
            query[0] = "select * from Adestrador where email_adestrador = '" + txtLogin.Text + "'and senha_adestrador = '" + txtSenha.Text + "'";
            query[1] = "select * from Dono where email_dono = '" + txtLogin.Text + "'and senha_dono = '" + txtSenha.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query[0], conn.conectarBD());
            DataTable dtb = new DataTable();
            Design telaPrincipal = new Design();
            sda.Fill(dtb);
            try
            {
                if (dtb.Rows.Count == 1)
                {
                    this.Hide();
                    telaPrincipal.Show();
                }
                else
                {
                    conn.desconectarBD();
                    sda = new SqlDataAdapter(query[1], conn.conectarBD());
                    sda.Fill(dtb);
                    if (dtb.Rows.Count == 1)
                    {
                        this.Hide();
                        telaPrincipal.Show();
                    }
                    else
                    {
                        conn.desconectarBD();
                        MessageBox.Show("Erro: Login ou senha inválidos");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err);
            }
        }
    }
}
