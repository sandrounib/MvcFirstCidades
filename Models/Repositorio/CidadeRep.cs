using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoCidades.Models.Repositorio
{
    public class CidadeRep
    {
        //1º passo: criaa a string de conexão
        string connectionString =@"Data source=.\SqlExpress;Initial Catalog=ProjetoCidades;uid=sa;pwd=senai@123";

        //2º passo: criar o método para listar as cidades
        public List<Cidade> Listar(){            
            
            List<Cidade> lstCidades = new List<Cidade>();
            //acessar o banco de dados
            SqlConnection con = new SqlConnection(connectionString);

            string SqlQuery = "Select * from Cidades";

            SqlCommand cmd = new SqlCommand(SqlQuery,con);

            //abre a conexão com o BD
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            //para percorrer nos dados usamos um While abaixo
            //até tiver dados
            while(sdr.Read()){
                //ante de criar os dados na lista criar uma variável para colocar os dados da lista
                Cidade cidade = new Cidade();

                cidade.Id =Convert.ToInt16(sdr["Id"]);
                cidade.Nome = sdr["Nome"].ToString();
                cidade.Estado = sdr["Estado"].ToString();
                cidade.Habitantes =Convert.ToInt16(sdr["Habitantes"]);

                lstCidades.Add(cidade);
            }
            con.Close();

            //retorno deve ser uma lista de cidade
            return lstCidades;
        }
        public void Cadastrar(Cidade cidade){
            SqlConnection con = new SqlConnection(connectionString);

            string Sqlquery = "insert into Cidades(Nome,Estado,Habitantes)"+
            "values('"+ cidade.Nome +"','" + cidade.Estado +"',"+ cidade.Habitantes+")";            
            
            SqlCommand cmd = new SqlCommand(Sqlquery,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    

    }
}