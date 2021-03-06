using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PIM_FINAL
{
    public class Reservas
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        DataTable reservas = new DataTable();
        DataTable calculo = new DataTable();
        public string mensagem = "";

        public void RegistrarReserva(string idHospede, string numeroQuarto, DateTime dataEntrada, DateTime dataSaida, float valorTotal)
        {
            //Comando Sql -- insert, update, delete (SqlCommand)
            cmd.CommandText = "insert into Table_Reservas (idHospede, numeroQuarto, dataEntrada, dataSaida, valorTotal ) values (@idHospede, @numeroQuarto, @dataEntrada, @dataSaida, @valorTotal)";

            //parametros
            cmd.Parameters.AddWithValue("@idHospede", idHospede);
            cmd.Parameters.AddWithValue("@numeroQuarto", numeroQuarto);
            cmd.Parameters.AddWithValue("@dataEntrada", dataEntrada);
            cmd.Parameters.AddWithValue("@dataSaida", dataSaida);
            cmd.Parameters.AddWithValue("@valorTotal", valorTotal);



            //conectar com o banco de dados (Conexao)
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso -- variavel mensagem
                this.mensagem = "Reservado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";

            }
        }

        public DataTable ListarPorHospede(string nome)
        {
            //string de consulta
            string consul = "select r.id as 'Numero da Reserva', r.numeroQuarto as 'Numero do Quarto', r.dataEntrada as 'Data de Entrada', r.dataSaida as 'Data de Saida', h.nome as 'Nome do Hospede', q.valor as 'Valor Diária', r.valorTotal as 'Valor Total' from Table_Reservas as r, Table_Hospedes as h, Table_Quartos as q where h.id = r.idHospede and r.numeroQuarto = q.numeroQuarto and h.nome like '%" + nome + "%'";

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                reservas.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(reservas);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return reservas;
            }
            catch (SqlException e)
            {
                return reservas;
            }
        }

        public DataTable ListarReservas()
        {
            //string de consulta
            string consul = "select r.id as 'Numero da Reserva', r.dataEntrada as 'Data de Entrada', r.dataSaida as 'Data de Saida', h.nome, q.valor from Table_Reservas as r, Table_Hospedes as h, Table_Quartos as q where h.id = r.idHospede and r.numeroQuarto = q.numeroQuarto";

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                reservas.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(reservas);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return reservas;
            }
            catch (SqlException e)
            {
                return reservas;
            }
        }

        public DataTable ListarReservasPorId(string id)
        {
            //string de consulta
            string consul = "select r.id, r.dataEntrada, r.dataSaida, r.numeroQuarto, h.nome, q.valor from Table_Reservas as r, Table_Hospedes as h, Table_Quartos as q where h.id = r.idHospede and q.numeroQuarto = r.numeroQuarto and r.id = " + id;

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                reservas.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(reservas);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return reservas;
            }
            catch (SqlException e)
            {
                return reservas;
            }
        }

        public void ExcluirReserva(string id)
        {
            //Comando Sql -- insert, update, delete (SqlCommand)
            cmd.CommandText = "delete from Table_Reservas where id = @id";

            //parametros
            cmd.Parameters.AddWithValue("@id", id);


            //conectar com o banco de dados (Conexao)
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso -- variavel mensagem
                this.mensagem = "Excluído com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";

            }

        }

        public void AtualizarReserva(string idReserva, string numeroQuarto, DateTime dataEntrada, DateTime dataSaida, float valorTotal)
        {
            //Comando Sql -- insert, update, delete (SqlCommand)
            cmd.CommandText = "update Table_Reservas set numeroQuarto=@numeroQuarto, dataEntrada=@dataEntrada, dataSaida=@dataSaida, valorTotal=@valorTotal where id=@id ";

            //parametros
            cmd.Parameters.AddWithValue("@id", idReserva);
            cmd.Parameters.AddWithValue("@numeroQuarto", numeroQuarto);
            cmd.Parameters.AddWithValue("@dataEntrada", dataEntrada);
            cmd.Parameters.AddWithValue("@dataSaida", dataSaida);
            cmd.Parameters.AddWithValue("@valorTotal", valorTotal);

            //conectar com o banco de dados (Conexao)
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso -- variavel mensagem
                this.mensagem = "Atualizado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar atualizar!";

            }
        }

        public DataTable GerarRelatorio(DateTime dataEntrada, DateTime dataSaida)
        {
            string consul = "select r.id, h.nome as 'Nome', h.cpf as 'CPF', r.dataEntrada as 'Data Entrada', r.dataSaida as 'Data Saída', r.numeroQuarto as 'Nº Quarto', q.valor as 'Valor Diária', r.valorTotal as 'Valor Total' from Table_Reservas as r, Table_Quartos as q, Table_Hospedes as h where r.dataEntrada >= '" + dataEntrada.ToString("yyyy/MM/dd") + "' and r.dataSaida <= '" + dataSaida.ToString("yyyy/MM/dd") + "' and r.numeroQuarto = q.numeroQuarto and r.idHospede = h.id";


            //conectar com o banco de dados (Conexao)
            try
            {   
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                reservas.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(reservas);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return reservas;
            }
            catch (SqlException e)
            {
                return reservas;

            }
        }

        public DataTable ValorTotalRelatorio(DateTime dataEntrada, DateTime dataSaida)
        {
            string consul = "select SUM(r.valorTotal) as total from Table_Reservas as r where r.dataEntrada >= '" + dataEntrada.ToString("yyyy/MM/dd") + "' and r.dataSaida <= '" + dataSaida.ToString("yyyy/MM/dd") + "'";

            //conectar com o banco de dados (Conexao)
            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                calculo.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(calculo);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return calculo;
            }   
            catch (SqlException e)
            {
                return calculo;

            }
        }

    }
}
