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
    class RepositorioUsuario
    {
        Conexao conn = new Conexao();
        public void salvarDono(Dono dono)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Usuario values " +
                    "(@nome_usuario," +
                    "@telefone_usuario," +
                    "@email_usuario," +
                    "@rua_usuario," +
                    "@numero_casaUsuario," +
                    "@bairro_usuario," +
                    "@cidade_usuario," +
                    "@estado_usuario," +
                    "@senha_usuario); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@nome_usuario", dono.Nome);
                cmd.Parameters.AddWithValue("@telefone_usuario", dono.Telefone);
                cmd.Parameters.AddWithValue("@email_usuario", dono.Email);
                cmd.Parameters.AddWithValue("@rua_usuario", dono.Rua);
                cmd.Parameters.AddWithValue("@numero_casaUsuario", dono.NumCasa);
                cmd.Parameters.AddWithValue("@bairro_usuario", dono.Bairro);
                cmd.Parameters.AddWithValue("@cidade_usuario", dono.Cidade);
                cmd.Parameters.AddWithValue("@estado_usuario", dono.Estado);
                cmd.Parameters.AddWithValue("@senha_usuario", dono.Senha);

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
                SqlCommand cmd = new SqlCommand("update Usuario set " +
                    "Nome = @nome_usuario, " +
                    "Telefone = @telefone_usuario, " +
                    "Email = @email_usuario, " +
                    "Rua = @rua_usuario, " +
                    "NumCasa = @numero_casaUsuario," +
                    "Bairro = @bairro_usuario," +
                    "Cidade = @cidade_usuario," +
                    "Estado = @estado_usuario," +
                    "Senha = @senha_usuario");

                cmd.Parameters.Add("@id_dono", SqlDbType.VarChar).Value = dono.IdDono;
                cmd.Parameters.Add("@nome_usuario", SqlDbType.VarChar).Value = dono.Nome;
                cmd.Parameters.Add("@telefone_usuario", SqlDbType.VarChar).Value = dono.Telefone;
                cmd.Parameters.Add("@email_usuario", SqlDbType.VarChar).Value = dono.Email;
                cmd.Parameters.Add("@rua_usuario", SqlDbType.VarChar).Value = dono.Rua;
                cmd.Parameters.Add("@numero_casaUsuario", SqlDbType.Int).Value = dono.NumCasa;
                cmd.Parameters.Add("@bairro_usuario", SqlDbType.VarChar).Value = dono.Bairro;
                cmd.Parameters.Add("@cidade_usuario", SqlDbType.VarChar).Value = dono.Cidade;
                cmd.Parameters.Add("@estado_usuario", SqlDbType.VarChar).Value = dono.Estado;
                cmd.Parameters.Add("@senha_usuario", SqlDbType.Int).Value = dono.Senha;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.desconectarBD();
            }
        }

        public void deleteDono(Dono dono)
        {

        }

        public void salvarAdestrador(Adestrador adestrador)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Usuario values " +
                    "(@nome_usuario," +
                    "@telefone_usuario," +
                    "@email_usuario," +
                    "@rua_usuario," +
                    "@numero_casaUsuario," +
                    "@bairro_usuario," +
                    "@cidade_usuario," +
                    "@estado_usuario," +
                    "@senha_usuario); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@nome_usuario", adestrador.Nome);
                cmd.Parameters.AddWithValue("@telefone_usuario", adestrador.Telefone);
                cmd.Parameters.AddWithValue("@email_usuario", adestrador.Email);
                cmd.Parameters.AddWithValue("@rua_usuario", adestrador.Rua);
                cmd.Parameters.AddWithValue("@numero_casaUsuario", adestrador.NumCasa);
                cmd.Parameters.AddWithValue("@bairro_usuario", adestrador.Bairro);
                cmd.Parameters.AddWithValue("@cidade_usuario", adestrador.Cidade);
                cmd.Parameters.AddWithValue("@estado_usuario", adestrador.Estado);
                cmd.Parameters.AddWithValue("@senha_usuario", adestrador.Senha);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("insert into Adestrador values " +
                    "(@cpf_adestrador); select @@IDENTITY;", conn.conectarBD());
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

        }

        public void deleteAdestrador(Adestrador adestrador)
        {

        }
    }
}
