using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Remuneracao
    {
        public decimal ValorBruto { get; private set; }
        public decimal ValorIRRF { get; set; }
        public decimal ValorINNS { get; set; }
        public decimal RendaLiquida { get; set; }

        public decimal CalculoRendaLiquida()
        {
            return ValorBruto - ValorIRRF - ValorINNS;
        }

        public void LerRendaBruta(decimal InRendaBruta)
        {
            ValorBruto = InRendaBruta;
        }
    }
}