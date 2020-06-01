using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Dependentes
    {
        public int QuantidadeDependentes{ get; private set; }

        public decimal CalcularDescontoDependentes(decimal renda)
        {
            return (renda - (QuantidadeDependentes * 189.59m));
        }

        public void LerDependentes(int Qty)
        {
            this.QuantidadeDependentes = Qty;
        }

    }
}
