using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Exercicio2001.LeituraArquivos
{
    internal class Leituracsv
    {
        public List<Entidades.Aluno> LeituraAlunos()
        {

            var Alunos = new List<Entidades.Aluno>();

            var caminho = @"C:\Users\USUARIO\Downloads\Alunos.csv";


            using (TextFieldParser arquivoAlunos = new TextFieldParser(caminho))
            {

                arquivoAlunos.SetDelimiters(new string[] { "," });

                arquivoAlunos.ReadLine();

                while (!arquivoAlunos.EndOfData)
                {
                    
                    string[] linha = arquivoAlunos.ReadFields();

                    var aluno = new Entidades.Aluno();

                    string telefone = linha[3].Replace("(", "").Replace(")", "").Replace(" ", "");

                    aluno.Identificador = linha[0];
                    aluno.Nome = linha[1];
                    aluno.Email = linha[2];
                    aluno.Telefone = Convert.ToInt64(telefone);
                    aluno.Endereco = linha[4];
                    aluno.DataCadastro = Convert.ToDateTime(linha[5]);

                    Alunos.Add(aluno);

                }

                return Alunos;
            }

        }

        public List<Entidades.Faturamentos> LeituraFaturamento()
        {
            var Faturamentos = new List<Entidades.Faturamentos>();

            var caminho2 = @"C:\Users\USUARIO\Downloads\Faturamentos.csv";

            using (TextFieldParser arquivoFaturamentos = new TextFieldParser(caminho2))
            {
                arquivoFaturamentos.SetDelimiters(new string[] { "," });

                arquivoFaturamentos.ReadLine();

                while (!arquivoFaturamentos.EndOfData)
                {
                    var faturamento = new Entidades.Faturamentos();
                    
                    string[] linha = arquivoFaturamentos.ReadFields();

                    char[] charsToTrim = { 'R', '$', '-'};

                    faturamento.Identificador = linha[0];
                    faturamento.DiaReferencia = Convert.ToDateTime(linha[1]);
                    faturamento.Faturamento = Convert.ToDecimal(linha[2].Trim(charsToTrim));
                    faturamento.Despesa = Convert.ToDecimal(linha[3].Replace("R$", " "));

                    Faturamentos.Add(faturamento);

                } 

            }
            return Faturamentos;

        }

        public List<Entidades.Propaganda> LeituraPropagandas()
        {
            var Propagandas = new List<Entidades.Propaganda>();

            var caminho3 = @"C:\Users\USUARIO\Downloads\Propagandas.csv";

            using (TextFieldParser arquivoPropagandas = new TextFieldParser(caminho3))
            {
                arquivoPropagandas.SetDelimiters(new string[] { "," });

                arquivoPropagandas.ReadLine();

                while (!arquivoPropagandas.EndOfData)
                {
                    var propaganda = new Entidades.Propaganda();

                    string[] linha = arquivoPropagandas.ReadFields();

                    propaganda.Identificador = linha[0];
                    propaganda.EmpresaDivulgadora = linha[1];
                    propaganda.CustoPropaganda = Convert.ToDecimal(linha[2]);
                    propaganda.DataPropaganda = Convert.ToDateTime(linha[3]);

                    Propagandas.Add(propaganda);

                }

            }
            return Propagandas;

        }
    }
}
