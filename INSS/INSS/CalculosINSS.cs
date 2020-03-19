using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculosINSS
    {
        const decimal INSS008 = 0.08m;
        const decimal INSS009 = 0.09m;
        const decimal INSS011 = 0.11m;

        public decimal CalculoINSS(decimal renda)
        {
            decimal calculo_INSS = 0;
            if (renda <= 1399.12m)
            {
                calculo_INSS = renda * INSS008;
            }
            if (renda >= 1399.13m && renda <= 2331.88m)
            {
                calculo_INSS = renda * INSS009;
            }
            else
            {
                calculo_INSS = renda * INSS011;
            }

            return calculo_INSS;
        }
    }
}
