using System;

namespace Exercicio2001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opcao desejada:");
            Console.WriteLine("(1) - Atualizar Banco de Dados dos Alunos");
            Console.WriteLine("(2) - Atualizar Banco de Dados do Faturamento");
            Console.WriteLine("(3) - Atualizar Banco de Dados do Setor de Propaganda");
            Console.WriteLine("(4) - Gerar Relatorio");
            Console.WriteLine("(5) - Gerar Relatorio Promoçoes");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    LeituraArquivos.Leituracsv leitura1 = new LeituraArquivos.Leituracsv();
                    var alunos = leitura1.LeituraAlunos();

                    foreach (var aluno in alunos)
                    {

                        BancoDeDados.Sql Banco1 = new BancoDeDados.Sql();
                        Banco1.InserirDadosAluno(aluno);

                    }

                    Console.WriteLine("Banco de dados Atualizado!");

                    break;

                case 2:

                    LeituraArquivos.Leituracsv leitura2 = new LeituraArquivos.Leituracsv();
                    var faturamentos = leitura2.LeituraFaturamento();

                    foreach (var fatura in faturamentos)
                    {

                        BancoDeDados.Sql Banco = new BancoDeDados.Sql();
                        Banco.InserirDadosFaturamento(fatura);

                    }

                    Console.WriteLine("Banco de dados Atualizado!");

                    break;

                case 3:

                    LeituraArquivos.Leituracsv leitura3 = new LeituraArquivos.Leituracsv();
                    var propagandas = leitura3.LeituraPropagandas();

                    foreach (var propaganda in propagandas)
                    {

                        BancoDeDados.Sql Banco = new BancoDeDados.Sql();
                        Banco.InserirDadosPropaganda(propaganda);

                    }
                    Console.WriteLine("Banco de dados Atualizado!");

                    break;

                case 4:

                    LeituraArquivos.Leituracsv leitura4 = new LeituraArquivos.Leituracsv();
                    var faturamento = leitura4.LeituraFaturamento();

                    Calculos.Calculo FaturamentoDespesa = new Calculos.Calculo();
                    var relatorio = FaturamentoDespesa.FaturamentoDespesas(faturamento);

                    FaturamentoDespesa.GerarRelatorio(relatorio);

                    Console.WriteLine("Arquivo Salvo com Sucesso!");

                    break;

                case 5:

                    LeituraArquivos.Leituracsv leitura5 = new LeituraArquivos.Leituracsv();
                    var alunos2 = leitura5.LeituraAlunos();

                    Promocoes.Promocao3meses promocao = new Promocoes.Promocao3meses();
                    var alunosPromocao = promocao.Promocao(alunos2);

                    promocao.GerarRelatorioPromocao(alunosPromocao);

                    Console.WriteLine("Arquivo Salvo com Sucesso!");


                    break;

                default:

                    Console.WriteLine("Opção Inválida");

                break;

            }

        }
    }
}
