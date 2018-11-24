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
    class RepositorioPet
    {
        Conexao conn = new Conexao();

        public void salvarPetDono(Pet pet)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Pet (id_dono,nome_pet,tipo_pet,raca_pet,genero_pet,avaliacao) values " +
                    "(@id_dono," +
                    "@nome_pet," +
                    "@tipo_pet," +
                    "@raca_pet," +
                    "@genero_pet," +
                    "@avaliacao); select @@IDENTITY;", conn.conectarBD());

                cmd.Parameters.AddWithValue("@id_dono", pet.IdDono);
                cmd.Parameters.AddWithValue("@nome_pet", pet.NomePet);
                cmd.Parameters.AddWithValue("@tipo_pet", pet.TipoPet);
                cmd.Parameters.AddWithValue("@raca_pet", pet.RacaPet);
                cmd.Parameters.AddWithValue("@genero_pet", pet.GeneroPet);
                cmd.Parameters.AddWithValue("@avaliacao", pet.AvaliacaoPet);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.desconectarBD();
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
        }

        public void upgradePet(Pet pet)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Pet set " +
                    "NomePet = @nome_pet, " +
                    "TipoPet = @tipo_pet, " +
                    "RacaPet = @raca_pet, " +
                    "GeneroPet = @genero_pet");

                cmd.Parameters.Add("@id_pet", SqlDbType.VarChar).Value = pet.IdPet;
                cmd.Parameters.Add("@nome_pet", SqlDbType.VarChar).Value = pet.NomePet;
                cmd.Parameters.Add("@tipo_pet", SqlDbType.VarChar).Value = pet.TipoPet;
                cmd.Parameters.Add("@raca_pet", SqlDbType.VarChar).Value = pet.RacaPet;
                cmd.Parameters.Add("@genero_pet", SqlDbType.VarChar).Value = pet.GeneroPet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.desconectarBD();
                MessageBox.Show("Cadastro efetuado com Sucesso");
            }
        }

        public void deletePet(Pet pet)
        {

        }

        public void consultarPet(Pet pet)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select @nome_pet,@raca_pet,@genero_pet,@avaliacao from Pet", conn.conectarBD());
                SqlDataReader ler = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.desconectarBD();
            }
        }
    }
}
