using SistemaPet.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.repositorio
{
    class RepositorioDono
    {
        Conexao conn = new Conexao();
        public void salvarDono(Dono dono)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Dono values " +
                    "(@nome_dono," +
                    "@telefone_dono," +
                    "@email_dono," +
                    "@rua_dono," +
                    "@numCasa_dono," +
                    "@bairro_dono," +
                    "@cidade_dono," +
                    "@estado_dono," +
                    "@senha_dono); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@nome_dono", dono.Nome);
                cmd.Parameters.AddWithValue("@telefone_dono", dono.Telefone);
                cmd.Parameters.AddWithValue("@email_dono", dono.Email);
                cmd.Parameters.AddWithValue("@rua_dono", dono.Rua);
                cmd.Parameters.AddWithValue("@numCasa_dono", dono.NumCasa);
                cmd.Parameters.AddWithValue("@bairro_dono", dono.Bairro);
                cmd.Parameters.AddWithValue("@cidade_dono", dono.Cidade);
                cmd.Parameters.AddWithValue("@estado_dono", dono.Estado);
                cmd.Parameters.AddWithValue("@senha_dono", dono.Senha);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.desconectarBD();
            }
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        public void updgradeDono(Dono dono)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Dono set " +
                    "nome_dono = @nome_dono, " +
                    "telefone_dono = @telefone_dono, " +
                    "email_dono = @email_dono, " +
                    "rua_dono = @rua_dono, " +
                    "numCasa_dono = @numCasa_dono," +
                    "bairro_dono = @bairro_dono," +
                    "cidade_dono = @cidade_dono," +
                    "estado_dono = @estado_dono where id_dono = "+dono.IdDono+";", conn.conectarBD());
                
                cmd.Parameters.Add("@nome_dono", SqlDbType.VarChar).Value = dono.Nome;
                cmd.Parameters.Add("@telefone_dono", SqlDbType.VarChar).Value = dono.Telefone;
                cmd.Parameters.Add("@email_dono", SqlDbType.VarChar).Value = dono.Email;
                cmd.Parameters.Add("@rua_dono", SqlDbType.VarChar).Value = dono.Rua;
                cmd.Parameters.Add("@numCasa_dono", SqlDbType.Int).Value = dono.NumCasa;
                cmd.Parameters.Add("@bairro_dono", SqlDbType.VarChar).Value = dono.Bairro;
                cmd.Parameters.Add("@cidade_dono", SqlDbType.VarChar).Value = dono.Cidade;
                cmd.Parameters.Add("@estado_dono", SqlDbType.VarChar).Value = dono.Estado;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MessageBox.Show("Alterado com Sucesso");
                conn.desconectarBD();
            }
        }

        public Dono GetDonoTelaPerfil(int idUser, Dono dono)
        {
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
            conn.desconectarBD();
            return dono;
        }

        public void deleteDono(Dono dono)
        {
            string sql = "DELETE FROM CLIENTE WHERE id_dono = txtIdDono.txt";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            conn.conectarBD();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }

            finally
            {
                conn.desconectarBD();
            }
        }
    }
}
