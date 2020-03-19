using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Salario
    {
        public decimal CalculoRendaLiquida(decimal renda, decimal irrf, decimal inss)
        {
            return renda - irrf - inss;
        }

        public decimal CalcularDescontoDependentes(decimal renda, int dependentes)
        {
            return (renda - (dependentes * 189.59m));
        }
    }
}
