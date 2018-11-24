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
    class RepositorioAdestrador
    {
        Conexao conn = new Conexao();
        public void salvarAdestrador(Adestrador adestrador)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Adestrador values " +
                    "(@nome_adestrador," +
                    "@telefone_adestrador," +
                    "@email_adestrador," +
                    "@rua_adestrador," +
                    "@numCasa_adestrador," +
                    "@bairro_adestrador," +
                    "@cidade_adestrador," +
                    "@estado_adestrador," +
                    "@senha_adestrador," +
                    "@cpf_adestrador); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@nome_adestrador", adestrador.Nome);
                cmd.Parameters.AddWithValue("@telefone_adestrador", adestrador.Telefone);
                cmd.Parameters.AddWithValue("@email_adestrador", adestrador.Email);
                cmd.Parameters.AddWithValue("@rua_adestrador", adestrador.Rua);
                cmd.Parameters.AddWithValue("@numCasa_adestrador", adestrador.NumCasa);
                cmd.Parameters.AddWithValue("@bairro_adestrador", adestrador.Bairro);
                cmd.Parameters.AddWithValue("@cidade_adestrador", adestrador.Cidade);
                cmd.Parameters.AddWithValue("@estado_adestrador", adestrador.Estado);
                cmd.Parameters.AddWithValue("@senha_adestrador", adestrador.Senha);
                cmd.Parameters.AddWithValue("@cpf_adestrador", adestrador.Cpf);

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
        public void upgradeAdestrador(Adestrador adestrador)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Adestrador set " +
                    "nome_adestrador = @nome_adestrador, " +
                    "telefone_adestrador = @telefone_adestrador, " +
                    "email_adestrador = @email_adestrador, " +
                    "rua_adestrador = @rua_adestrador, " +
                    "numCasa_adestrador = @numCasa_adestrador," +
                    "bairro_adestrador = @bairro_adestrador," +
                    "cidade_adestrador = @cidade_adestrador," +
                    "estado_adestrador = @estado_adestrador where id_adestrador = " + adestrador.IdAdestrador + ";", conn.conectarBD());

                cmd.Parameters.Add("@nome_adestrador", SqlDbType.VarChar).Value = adestrador.Nome;
                cmd.Parameters.Add("@telefone_adestrador", SqlDbType.VarChar).Value = adestrador.Telefone;
                cmd.Parameters.Add("@email_adestrador", SqlDbType.VarChar).Value = adestrador.Email;
                cmd.Parameters.Add("@rua_adestrador", SqlDbType.VarChar).Value = adestrador.Rua;
                cmd.Parameters.Add("@numCasa_adestrador", SqlDbType.Int).Value = adestrador.NumCasa;
                cmd.Parameters.Add("@bairro_adestrador", SqlDbType.VarChar).Value = adestrador.Bairro;
                cmd.Parameters.Add("@cidade_adestrador", SqlDbType.VarChar).Value = adestrador.Cidade;
                cmd.Parameters.Add("@estado_adestrador", SqlDbType.VarChar).Value = adestrador.Estado;

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

        public void deleteAdestrador(Adestrador adestrador)
        {

        }

        public void consultarAdestrador(Adestrador adestrador)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select " +
                    "(@nome_adestrador," +
                    "@telefone_adestrador," +
                    "@email_adestrador," +
                    "@rua_adestrador," +
                    "@numCasa_adestrador," +
                    "@bairro_adestrador," +
                    "@cidade_adestrador," +
                    "@estado_adestrador," +
                    "@senha_adestrador," +
                    "@cpf_adestrador); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@nome_adestrador", adestrador.Nome);

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

        public Adestrador GetAdestradorTelaPerfil(int idUser, Adestrador adestrador)
        {
            SqlCommand cmd = new SqlCommand("select * from Adestrador where id_adestrador = " + idUser, conn.conectarBD());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                adestrador.IdAdestrador = Convert.ToInt16(dr[0]);
                adestrador.Nome = Convert.ToString(dr[1]);
                adestrador.Telefone = Convert.ToString(dr[2]);
                adestrador.Email = Convert.ToString(dr[3]);
                adestrador.Rua = Convert.ToString(dr[4]);
                adestrador.NumCasa = Convert.ToInt16(dr[5]);
                adestrador.Bairro = Convert.ToString(dr[6]);
                adestrador.Cidade = Convert.ToString(dr[7]);
                adestrador.Estado = Convert.ToString(dr[8]);
            }
            conn.desconectarBD();
            return adestrador;
        }
    }
}
