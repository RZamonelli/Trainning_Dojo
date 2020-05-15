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