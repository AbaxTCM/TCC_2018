using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Conexao
{

    SqlConnection conn = new SqlConnection("User ID=sa;Initial Catalog=db_sistemaPet;Data Source=PCNAME;Password=1234567");

    public SqlConnection conectarBD()
    {
        try
        {
            conn.Open();
        }
        catch (Exception e)
        {
            MessageBox.Show("Falha ao conectar.\nDetalhesde erro: " + e);
        }
        return conn;

    }

    public SqlConnection desconectarBD()
    {
        try
        {
            conn.Close();
            //MessageBox.Show("Desconectado com sucesso!");
        }
        catch (Exception e)
        {
            MessageBox.Show("Falha ao desconectar.\nDetalhes do erro: " + e);
        }
        return conn;
    }

    public void checarconexao()
    {
        if (conn != null && conn.State != ConnectionState.Closed)
        {
            MessageBox.Show("Conectado com Sucesso");
        }
        else
        {
            MessageBox.Show("Falha ao conectar Banco de Dados");
        }
    }
}
