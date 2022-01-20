using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio2001.Calculos
{
    public class Calculo
    {
        public Entidades.Relatorios FaturamentoDespesas(List<Entidades.Faturamentos> faturamentos)
        {
            var relatorio = new Entidades.Relatorios();

            //Faturamento total durante todo o período.
            decimal somaFaturamento = faturamentos.Sum(c => c.Faturamento);

            //A despesas totais durante todo o período

            decimal somaDespesas = faturamentos.Sum(c => c.Despesa);

            //Lucro total durante todo o período. 

            decimal LucroTotal = somaFaturamento - somaDespesas;

            relatorio.somaFaturamentos = Convert.ToString(somaFaturamento);
            relatorio.somaDespesa = Convert.ToString(somaDespesas);
            relatorio.Lucro = Convert.ToString(LucroTotal);

            return relatorio;

        }

        public void GerarRelatorio(Entidades.Relatorios relatorios)
        {
            string path = @"C:\Users\USUARIO\Downloads\Relatorio.csv";

                string[] createText = { "Relatório",
                    "Faturamento Total:", relatorios.somaFaturamentos, 
                    "Despesas Totais:",relatorios.somaDespesa, 
                    "Lucro Total:", relatorios.Lucro };
                File.WriteAllLines(path, createText);


        }


    }
}
