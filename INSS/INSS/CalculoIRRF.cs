using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.Util;

namespace INSS
{
    public class CalculoIRRF
    {
        public decimal CalcularIRRF(decimal renda, int dependentes)
        {
            //var salario = new Salario();
            //var calculo_IMP = salario.CalcularDescontoDependentes(renda, dependentes);
            //decimal resultado = 0;

            //if (calculo_IMP <= 1903.98m)
            //{
            //    resultado = 0;
            //}
            //else
            //if (calculo_IMP >= 1903.08m && calculo_IMP <= 2826.65m)
            //{
            //    resultado = calculo_IMP * ConstantIRRF.IRRF0075;
            //}
            //else
            //if (calculo_IMP >= 2826.65m && calculo_IMP <= 3751.05m)
            //{
            //    resultado = calculo_IMP * ConstantIRRF.IRRF015;
            //}
            //else
            //if (calculo_IMP >= 3751.05m && calculo_IMP <= 4664.68m)
            //{
            //    resultado = calculo_IMP * ConstantIRRF.IRRF0275;
            //}
            //return resultado;

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
            return formulaIRRF(calculo_IMP, calculo_IMP <= 1903.98m ? 0 : 
                                            calculo_IMP <= 2826.65m ? ConstantIRRF.IRRF0075: 
                                            calculo_IMP <= 3751.05m ? ConstantIRRF.IRRF015 :
                                            calculo_IMP <= 4664.68m ? ConstantIRRF.IRRF0275 :
                                            0);
        }

        private decimal formulaIRRF(decimal calcImp, decimal IRRF)
        {
            return calcImp * IRRF;
        }
    }
}