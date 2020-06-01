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
            var salario = new Remuneracao();
            var rendaDependentes = salario.CalcularDescontoDependentes(renda, dependentes);
            return CalcularSalarioIRRF(rendaDependentes);
        }

        private static decimal CalcularSalarioIRRF(decimal rendaDependentes)
        {
            switch (rendaDependentes)
            {
                case var renda when renda <= ConstantIRRF.RENDA190398:
                    return 0;
                case var renda when renda > ConstantIRRF.RENDA190398 && renda <= ConstantIRRF.RENDA282665:
                    return rendaDependentes * ConstantIRRF.IRRF0075;
                case var renda when renda > ConstantIRRF.RENDA282665 && renda <= ConstantIRRF.RENDA375105:
                    return rendaDependentes * ConstantIRRF.IRRF015;
                case var renda when renda > ConstantIRRF.RENDA375105 && renda <= ConstantIRRF.RENDA466468:
                    return rendaDependentes * ConstantIRRF.IRRF0275;
                default:
                    return 0;
            }
        }
    }
}