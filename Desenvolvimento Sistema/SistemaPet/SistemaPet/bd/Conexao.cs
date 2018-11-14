using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Conexao
{

    MySqlConnection conn = new MySqlConnection("SERVER=31.170.160.59;PORT=3306;DATABASE=id7841393_db_sistemapet;UID=abaxtcm@gmail.com;PASSWORD=abax2018;");

    public MySqlConnection conectarBD()
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

    public MySqlConnection desconectarBD()
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
