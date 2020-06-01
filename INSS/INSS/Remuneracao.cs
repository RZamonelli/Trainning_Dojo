using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Remuneracao
    {
        private decimal valorBruto;
        private decimal valorIRRF;
        private decimal valorINNS;
        private decimal rendaLiquida;

        public decimal ValorBruto { get => valorBruto; set => valorBruto = value; }
        public decimal ValorIRRF { get => valorIRRF; set => valorIRRF = value; }
        public decimal ValorINNS { get => valorINNS; set => valorINNS = value; }
        public decimal RendaLiquida { get => rendaLiquida; set => rendaLiquida = value; }

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