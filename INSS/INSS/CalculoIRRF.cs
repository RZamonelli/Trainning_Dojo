using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.Util;

namespace INSS
{
    public abstract class CalculoIRRF
    {
        public abstract decimal CalcularIRRF(decimal rendaDependentes);
    }

    class FaixaUm: CalculoIRRF
    {
        public override decimal CalcularIRRF(decimal rendaDependentes)
        {
            return 0;
        }
    }

    class FaixaDois: CalculoIRRF
    {
        public override decimal CalcularIRRF(decimal rendaDependentes)
        {
            return rendaDependentes * ConstantIRRF.IRRF0075;
        }
    }

    class FaixaTres: CalculoIRRF
    {
        public override decimal CalcularIRRF(decimal rendaDependentes)
        {
            return rendaDependentes * ConstantIRRF.IRRF015;
        }
    }
    class FaixaQuatro: CalculoIRRF
    {
        public override decimal CalcularIRRF(decimal rendaDependentes)
        {
            return rendaDependentes * ConstantIRRF.IRRF0275;
        }
    }


    /* public class CalculoIRRF
 {
     private Dependentes dependente;
     private decimal RemuDescDependente;

     public decimal GetRemuDescDependente()
     {
         return RemuDescDependente;
     }

     public void SetRemuDescDependente(decimal value)
     {
         RemuDescDependente = value;
     }

     public CalculoIRRF(Dependentes CalcDependente)
     {
         dependente = CalcDependente;
     }
     public decimal CalcularIRRF(decimal renda, int dependentes)
     {
         var rendaDependentes = dependente.CalcularDescontoDependentes(renda);
         CalculoIRRF2 teste = new FaixaUm();
         teste.CalcularIRRF(rendaDependentes);
         return 0;//new FaixaUm().CalcularSalarioIRRF(rendaDependentes);
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
 }*/
}