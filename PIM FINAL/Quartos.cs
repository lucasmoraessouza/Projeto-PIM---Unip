using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PIM_FINAL
{
    public class Quartos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        DataTable quartos = new DataTable();
        public string mensagem = "";

        public DataTable ListarQuartosDisponiveis()
        {
            //string de consulta
            string consul = "select q.numeroQuarto, q.valor from Table_Quartos as q left join Table_Reservas as r on r.numeroQuarto = q.numeroQuarto where r.dataSaida is null or r.dataSaida < '" + DateTime.Now.ToString() + "'";

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                quartos.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(quartos);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return quartos;
            }
            catch (SqlException e)
            {
                return quartos;
            }
        }
    }
}
