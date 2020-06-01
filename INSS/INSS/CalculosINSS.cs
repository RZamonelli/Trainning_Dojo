using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.Util;

namespace INSS
{
   
    public class CalculosINSS
    {
        public decimal CalculoINSS(decimal renda)
        {
            return formulaINSS(renda, renda <= 1903.98m ? ConstantINSS.INSS008 :
                                      renda <= 2331.88m ? ConstantINSS.INSS009 :
                                      renda <= 3751.05m ? ConstantIRRF.IRRF015 :
                                      ConstantINSS.INSS011);

        }

        private decimal formulaINSS(decimal renda, decimal Inss){
            return renda * Inss;       
        }
    }
}
