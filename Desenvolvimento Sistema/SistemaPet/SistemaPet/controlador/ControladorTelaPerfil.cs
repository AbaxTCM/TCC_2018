using SistemaPet.dominio;
using SistemaPet.tela;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.controlador
{
    class ControladorTelaPerfil
    {
        public void obterRegistros(int idUser)
        {
            Dono dono = new Dono();
            Conexao conn = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from Dono where id_dono = " + idUser, conn.conectarBD());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dono.IdDono = Convert.ToInt16(dr[0]);
                dono.Nome = Convert.ToString(dr[1]);
                dono.Telefone = Convert.ToString(dr[2]);
                dono.Email = Convert.ToString(dr[3]);
                dono.Rua = Convert.ToString(dr[4]);
                dono.NumCasa = Convert.ToInt16(dr[5]);
                dono.Bairro = Convert.ToString(dr[6]);
                dono.Cidade = Convert.ToString(dr[7]);
                dono.Estado = Convert.ToString(dr[8]);
            }
        }
    }
}
