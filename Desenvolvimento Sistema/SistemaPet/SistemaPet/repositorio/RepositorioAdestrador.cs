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

        }

        public void deleteAdestrador(Adestrador adestrador)
        {

        }
    }
}
