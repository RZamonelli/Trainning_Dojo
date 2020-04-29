using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculosINSS
    {
        private const decimal INSS008 = 0.08m;
        private const decimal INSS009 = 0.09m;
        private const decimal INSS011 = 0.11m;
        private const decimal RendaMax008 = 1399.12m;
        private const decimal RendaMin009 = 1399.13m;
        private const decimal RendaMax009 = 2331.88m;



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
                    return formulaINSS(renda, INSS008);
                case var expression when (renda >= 1399.13m && renda <= 2331.88m):
                    return formulaINSS(renda, INSS009);
                default:
                    return formulaINSS(renda, INSS011);
            }

           
        }

        private decimal formulaINSS(decimal renda, decimal Inss){
            return renda * Inss;       
        }
    }
}
