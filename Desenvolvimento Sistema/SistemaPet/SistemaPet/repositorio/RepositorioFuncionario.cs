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
    class RepositorioFuncionario
    {
        Conexao conn = new Conexao();
        public void salvarFunc(Funcionario funcionario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Funcionario values " +
                    "(@nome_func," +
                    "@cargo_func," +
                    "@telefone_func," +
                    "@email_func," +
                    "@rua_func," +
                    "@numCasa_func," +
                    "@bairro_func," +
                    "@cidade_func," +
                    "@estado_func," +
                    "@senha_func); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@nome_func", funcionario.Nome);
                cmd.Parameters.AddWithValue("@cargo_func", funcionario.CargoFuncionario);
                cmd.Parameters.AddWithValue("@telefone_func", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@email_func", funcionario.Email);
                cmd.Parameters.AddWithValue("@rua_func", funcionario.Rua);
                cmd.Parameters.AddWithValue("@numCasa_func", funcionario.NumCasa);
                cmd.Parameters.AddWithValue("@bairro_func", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@cidade_func", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@estado_func", funcionario.Estado);
                cmd.Parameters.AddWithValue("@senha_func", funcionario.Senha);

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

        public void updgradeFunc(Funcionario funcionario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Funcionario set " +
                    "nome_func = @nome_func, " +
                    "cargo_func = @cargo_func," +
                    "telefone_func = @telefone_func, " +
                    "email_func = @email_func, " +
                    "rua_func = @rua_func, " +
                    "numCasa_func = @numCasa_func," +
                    "bairro_func = @bairro_func," +
                    "cidade_func = @cidade_func," +
                    "estado_func = @estado_func where id_func = " + funcionario.IdFuncionario + ";", conn.conectarBD());

                cmd.Parameters.Add("@nome_func", SqlDbType.VarChar).Value = funcionario.Nome;
                cmd.Parameters.Add("@cargo_func", SqlDbType.VarChar).Value = funcionario.CargoFuncionario;
                cmd.Parameters.Add("@telefone_func", SqlDbType.VarChar).Value = funcionario.Telefone;
                cmd.Parameters.Add("@email_func", SqlDbType.VarChar).Value = funcionario.Email;
                cmd.Parameters.Add("@rua_func", SqlDbType.VarChar).Value = funcionario.Rua;
                cmd.Parameters.Add("@numCasa_func", SqlDbType.Int).Value = funcionario.NumCasa;
                cmd.Parameters.Add("@bairro_func", SqlDbType.VarChar).Value = funcionario.Bairro;
                cmd.Parameters.Add("@cidade_func", SqlDbType.VarChar).Value = funcionario.Cidade;
                cmd.Parameters.Add("@estado_func", SqlDbType.VarChar).Value = funcionario.Estado;

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

        public Funcionario GetFuncTelaPerfil(int idUser, Funcionario funcionario)
        {
            SqlCommand cmd = new SqlCommand("select * from Funcionario where id_func = " + idUser, conn.conectarBD());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario.IdFuncionario = Convert.ToInt16(dr[0]);
                funcionario.Nome = Convert.ToString(dr[1]);
                funcionario.CargoFuncionario = Convert.ToString(dr[2]);
                funcionario.Telefone = Convert.ToString(dr[3]);
                funcionario.Email = Convert.ToString(dr[4]);
                funcionario.Rua = Convert.ToString(dr[5]);
                funcionario.NumCasa = Convert.ToInt16(dr[6]);
                funcionario.Bairro = Convert.ToString(dr[7]);
                funcionario.Cidade = Convert.ToString(dr[8]);
                funcionario.Estado = Convert.ToString(dr[9]);
            }
            conn.desconectarBD();
            return funcionario;
        }
    }
}
