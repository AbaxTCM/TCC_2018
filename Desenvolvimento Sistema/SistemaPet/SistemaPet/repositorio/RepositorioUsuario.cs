using MySql.Data.MySqlClient;
using SistemaPet.dominio;
using System;
using System.Collections.Generic;
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
                MySqlCommand cmd = new MySqlCommand("insert into Usuario values " +
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

        }

        public void deleteDono(Dono dono)
        {

        }

        public void salvarAdestrador(Adestrador adestrador)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into Usuario values " +
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

                cmd = new MySqlCommand("insert into Adestrador values " +
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
