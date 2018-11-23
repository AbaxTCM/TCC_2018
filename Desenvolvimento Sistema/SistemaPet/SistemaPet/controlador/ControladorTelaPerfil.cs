using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.controlador
{
    class ControladorTelaPerfil
    {
        public void obterRegistros(int idUser)
        {
            Conexao conn = new Conexao();
            int id = idUser;
            SqlCommand cmd = new SqlCommand("select * from Dono where id_dono = '" + idUser, conn.conectarBD());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
                idUser = Convert.ToInt16(dr[0]);
            }
        }
    }
}
