using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PIM_FINAL
{
    public class Hospedes
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        DataTable hospedes = new DataTable();
        public String mensagem = "";
        public void Cadastro(String nome, String nascimento, String cpf, String email, String cep, String telefone)
        {
            //Comando Sql -- insert, update, delete (SqlCommand)
            cmd.CommandText = "insert into Table_Hospedes (nome, nascimento, cpf, email, cep, telefone) values (@nome, @nascimento, @cpf, @email, @cep, @telefone)";

            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@nascimento", nascimento);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);


            //conectar com o banco de dados (Conexao)
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso -- variavel mensagem
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";

            }
        }

        public void AtualizarCadastro(String id, String nome, String nascimento, String cpf, String email, String cep, String telefone)
        {
            //Comando Sql -- insert, update, delete (SqlCommand)
            cmd.CommandText = "update Table_Hospedes set nome=@nome, nascimento=@nascimento, cpf=@cpf, email=@email, cep=@cep, telefone=@telefone where id=@id ";

            //parametros
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@nascimento", nascimento);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);


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

        public DataTable ListarTodos()
        {
            //string de consulta
           string consul = "select * from Table_Hospedes";

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                hospedes.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(hospedes);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return hospedes;
            }
            catch (SqlException e)
            {
                return hospedes;
            }
        }

        public DataTable ListarNome(string nome)
        {
            //string de consulta
            string consul = "select * from Table_Hospedes where nome like '%" + nome + "%'";

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                hospedes.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(hospedes);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return hospedes;
            }
            catch (SqlException e)
            {
                return hospedes;
            }
        }


        public DataTable ListarId(string id)
        {
            //string de consulta
            string consul = "select * from Table_Hospedes where id = " + id;

            try
            {
                //conexao BD
                cmd.Connection = conexao.conectar();

                //executar comando
                SqlDataAdapter dataAdp = new SqlDataAdapter(consul, conexao.conectar());

                //limpando datatable
                hospedes.Clear();

                //guardando os valores da consulta no data table
                dataAdp.Fill(hospedes);

                //desconectar
                conexao.desconectar();

                //retornando data table
                return hospedes;
            }
            catch (SqlException e)
            {
                return hospedes;
            }
        }

        public void ExcluirHospede(string id)
        {
            //Comando Sql -- insert, update, delete (SqlCommand)
            cmd.CommandText = "delete from Table_Hospedes where id = @id";

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
    }
}
