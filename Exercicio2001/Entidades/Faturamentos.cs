using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2001.Entidades
{
    public class Faturamentos
    {
        public string Identificador { get; set; }

        public DateTime DiaReferencia { get; set; }

        public decimal Faturamento { get; set; }

        public decimal Despesa { get; set; }

    }
}
