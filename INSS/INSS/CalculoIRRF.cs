using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculoIRRF
    {
        const decimal IRRF0075 = 0.075m;
        const decimal IRRF015 = 0.15m;
        const decimal IRRF0275 = 0.275m;

        public decimal CalcularIRRF(decimal renda, int dependentes)
        {
            var salario = new Salario();
            var calculo_IMP = salario.CalcularDescontoDependentes(renda, dependentes);
            decimal resultado = 0;

            if (calculo_IMP <= 1903.98m)
            {
                resultado = 0;
            }
            else
            if (calculo_IMP >= 1903.08m && calculo_IMP <= 2826.65m)
            {
                resultado = calculo_IMP * IRRF0075;
            }
            else
            if (calculo_IMP >= 2826.65m && calculo_IMP <= 3751.05m)
            {
                resultado = calculo_IMP * IRRF015;
            }
            else
            if (calculo_IMP >= 3751.05m && calculo_IMP <= 4664.68m)
            {
                resultado = calculo_IMP * IRRF0275;
            }
            return resultado;
        }
    }
}