using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PIM_FINAL
{
    public class Conexao
    {
            SqlConnection con = new SqlConnection();
        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-OIE66TM\SQLLUCAS;Initial Catalog=PIM;Integrated Security=True";
        }
        //Metodo Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }        
        }
    }
}
