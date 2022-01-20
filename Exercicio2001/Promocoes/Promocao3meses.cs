using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio2001.Promocoes
{
    public class Promocao3meses
    {

        public List<Entidades.AlunosPromocao> Promocao(List<Entidades.Aluno> alunos)
        {
            var AlunosPromocao = new List<Entidades.AlunosPromocao>();

            foreach (var aluno in alunos)
            {
                string ano = Convert.ToString(aluno.DataCadastro);

                ano = ano.Substring(6, 5);

                int ano2 = int.Parse(ano);

                if (ano2 == 2019)
                {
                    var alunoPromocao = new Entidades.AlunosPromocao();

                    alunoPromocao.Identificador = aluno.Identificador;
                    alunoPromocao.NomePromocao = aluno.Nome;

                    AlunosPromocao.Add(alunoPromocao);
                }
            }
            
            return AlunosPromocao;
        }

        public void GerarRelatorioPromocao(List<Entidades.AlunosPromocao> alunosPromocao)
        {
            string path = @"C:\Users\USUARIO\Downloads\RelatorioPromocao.txt";

            File.WriteAllText(path, "Relatório Promoção - Iniciaram em 2019\n");

            foreach (var aluno1 in alunosPromocao)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("--------------------------------------");
                    sw.WriteLine("Identificador:" + aluno1.Identificador);
                    sw.WriteLine("Nome:"+ aluno1.NomePromocao);
                    sw.WriteLine("--------------------------------------");
                }
              
            }
        }

    }
}
