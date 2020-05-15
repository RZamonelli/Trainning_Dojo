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
        //bool IsInss008v 
        public decimal CalculoINSS(decimal renda)
        {
            //decimal calculo_INSS = 0;
            //if (renda <= 1399.12m)
            //{
            //    calculo_INSS = renda * INSS008;
            //}
            //if (renda >= 1399.13m && renda <= 2331.88m)
            //{
            //    calculo_INSS = renda * INSS009;
            //}
            //else
            //{
            //    calculo_INSS = renda * INSS011;
            //}

            switch (renda)
            {
                case var expression when renda <= 1399.12m:
                    return formulaINSS(renda, ConstantINSS.INSS008);
                case var expression when (renda >= 1399.13m && renda <= 2331.88m):
                    return formulaINSS(renda, ConstantINSS.INSS009);
                default:
                    return formulaINSS(renda, ConstantINSS.INSS011);
            }

           
        }

        private decimal formulaINSS(decimal renda, decimal Inss){
            return renda * Inss;       
        }
    }
}
