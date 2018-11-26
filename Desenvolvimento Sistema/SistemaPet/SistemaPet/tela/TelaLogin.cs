using SistemaPet.controlador;
using SistemaPet.dominio;
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
using static SistemaPet.controlador.ControladorTelaLogin;

namespace SistemaPet.tela
{
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
            txtLogin.Focus();

        }

        Conexao conn = new Conexao();
        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void lklRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaApresentacaoRegistro preCadastro = new TelaApresentacaoRegistro();
            preCadastro.Show();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string[] query;
            query = new string[3];
            query[0] = "select * from Adestrador where email_adestrador = '" + txtLogin.Text + "'and senha_adestrador = '" + txtSenha.Text + "'";
            query[1] = "select * from Dono where email_dono = '" + txtLogin.Text + "'and senha_dono = '" + txtSenha.Text + "'";
            query[2] = "select * from Funcionario where email_func ='" + txtLogin.Text + "' and senha_func ='" + txtSenha.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query[0], conn.conectarBD());
            DataTable dtb = new DataTable();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            sda.Fill(dtb);
            int idUser = 0;
            string funcao = "";
            try
            {
                if (dtb.Rows.Count == 1)
                {
                    conn.desconectarBD();
                    this.Hide();
                    telaPrincipal.Show();
                    SqlCommand cmd = new SqlCommand("select id_adestrador from Adestrador where email_adestrador = '" + txtLogin.Text + "' and senha_adestrador = '" + txtSenha.Text + "'", conn.conectarBD());
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        idUser = Convert.ToInt16(dr[0]);
                        funcao = "Adestrador";
                    }
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
                        conn.desconectarBD();
                        SqlCommand cmd = new SqlCommand("select id_dono from Dono where email_dono = '" + txtLogin.Text + "' and senha_dono = '" + txtSenha.Text + "'", conn.conectarBD());
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            idUser = Convert.ToInt16(dr[0]);
                            funcao = "Dono";
                        }
                    }
                    else
                    {
                        conn.desconectarBD();
                        sda = new SqlDataAdapter(query[2], conn.conectarBD());
                        sda.Fill(dtb);
                        if (dtb.Rows.Count == 1)
                        {
                            this.Hide();
                            telaPrincipal.Show();
                            conn.desconectarBD();
                            SqlCommand cmd = new SqlCommand("select * from Funcionario where email_func ='" + txtLogin.Text + "' and senha_func ='" + txtSenha.Text + "'", conn.conectarBD());
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                idUser = Convert.ToUInt16(dr[0]);
                                funcao = "Funcionario";
                            }
                        }
                        else
                        {
                            conn.desconectarBD();
                            MessageBox.Show("Erro: Login ou senha inválidos");
                            txtLogin.Clear();
                            txtSenha.Clear();
                            txtLogin.Focus();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err);
            }
            finally
            {
                Session.Instance.UserID = idUser;
                Session.Instance.Funcao = funcao;
            }
        }
    }
}