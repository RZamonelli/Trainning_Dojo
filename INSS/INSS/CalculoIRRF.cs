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

        const decimal SALARIO190398 = 1903.98m;
        const decimal SALARIO282665 = 2826.65m;
        const decimal SALARIO375105 = 3751.05m;
        const decimal SALARIO466468 = 4664.68m;

        public decimal CalcularIRRF(decimal renda, int dependentes)
        {
            var salario = new Salario();
            var calculo_IMP = salario.CalcularDescontoDependentes(renda, dependentes);
            return CalcularSalarioIRRF(calculo_IMP);
        }

        private static decimal CalcularSalarioIRRF(decimal calculo_IMP)
        {
            switch (calculo_IMP)
            {
                case var d when d <= SALARIO190398:
                    return 0;
                case var d when d > SALARIO190398 && d <= SALARIO282665:
                    return calculo_IMP * IRRF0075;
                case var d when d > SALARIO282665 && d <= SALARIO375105:
                    return calculo_IMP * IRRF015;
                case var d when d > SALARIO375105 && d <= SALARIO466468:
                    return calculo_IMP * IRRF0275;
                default:
                    return 0;
            }
        }
    }
}