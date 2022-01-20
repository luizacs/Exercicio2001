using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Exercicio2001.BancoDeDados
{
    public class Sql
    {
        public readonly SqlConnection _conexao;

        public Sql()
        {
            this._conexao = new SqlConnection(File.ReadAllText(@"C:\Users\USUARIO\Documents\Curos Rumo\Aula05\Credenciais.txt"));

        }
        public void InserirDadosAluno(Entidades.Aluno aluno)
        {
            try
            {
                _conexao.Open();

                string sqlInsert = @"INSERT INTO Aluno
                               (Identificador
                               ,Nome
                               ,Email
                               ,Telefone
                               ,Endereco
                               ,DataCadastro)
                         VALUES
                               (@Identificador
                               ,@Nome
                               ,@Email
                               ,@Telefone
                               ,@Endereco
                               ,@DataCadastro)";


                    using (SqlCommand cmd = new SqlCommand(sqlInsert, _conexao))
                    {

                        cmd.Parameters.AddWithValue("Identificador", aluno.Identificador);
                        cmd.Parameters.AddWithValue("Nome", aluno.Nome);
                        cmd.Parameters.AddWithValue("Email", aluno.Email);
                        cmd.Parameters.AddWithValue("Telefone", aluno.Telefone);
                        cmd.Parameters.AddWithValue("Endereco", aluno.Endereco);
                        cmd.Parameters.AddWithValue("DataCadastro", aluno.DataCadastro);
                    }

                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, _conexao))
                    {

                        cmd.Parameters.AddWithValue("Nome", aluno.Nome);
                        cmd.Parameters.AddWithValue("Email", aluno.Email);
                        cmd.Parameters.AddWithValue("Telefone", aluno.Telefone);
                        cmd.Parameters.AddWithValue("Endereco", aluno.Endereco);
                        cmd.Parameters.AddWithValue("DataCadastro", aluno.DataCadastro);

                        cmd.ExecuteNonQuery();
                    }

            }

            finally
            {
                _conexao.Close();
            }

        }

        public void InserirDadosFaturamento(Entidades.Faturamentos faturamento)
        {
            try
            {
                _conexao.Open();

                string sql1 = @"INSERT INTO Faturamento
                               (Identificador
                               ,TotalEntrada
                               ,TotalSaida
                               ,DiaReferencia
                               )
                         VALUES
                               (@Identificador
                               ,@TotalEntrada
                               ,@TotalSaida
                               ,@DiaReferencia)";

                using (SqlCommand cm = new SqlCommand(sql1, _conexao))
                {
                    cm.Parameters.AddWithValue("Identificador", faturamento.Identificador);
                    cm.Parameters.AddWithValue("DiaReferencia", faturamento.DiaReferencia);
                    cm.Parameters.AddWithValue("TotalEntrada", faturamento.Faturamento);
                    cm.Parameters.AddWithValue("TotalSaida", faturamento.Despesa);

                    cm.ExecuteNonQuery();
                }
            }

            finally
            {
                _conexao.Close();
            }
        }

            public void InserirDadosPropaganda(Entidades.Propaganda propaganda)
            {
                try
                {
                    _conexao.Open();

                    string sql2 = @"INSERT INTO Propaganda
                               (Identificador
                               ,EmpresaDivulgadora
                               ,Custo
                               ,DataPropaganda
                               )
                         VALUES
                               (@Identificador
                               ,@EmpresaDivulgadora
                               ,@Custo
                               ,@DataPropaganda)";

                    using (SqlCommand com = new SqlCommand(sql2, _conexao))
                    {
                        com.Parameters.AddWithValue("Identificador", propaganda.Identificador);
                        com.Parameters.AddWithValue("EmpresaDivulgadora", propaganda.EmpresaDivulgadora);
                        com.Parameters.AddWithValue("Custo", propaganda.CustoPropaganda);
                        com.Parameters.AddWithValue("DataPropaganda", propaganda.DataPropaganda);

                        com.ExecuteNonQuery();
                    }
                }

                finally
                {
                    _conexao.Close();
                }

            }
    }
}
