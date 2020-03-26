using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Program
    {
        static void Main(string[] args)
        {
            int dependentes = 0;
            int i, x, z;
            decimal calculo_INSS = 0, renda = 0, calculo_IMP = 0, resultado = 0, liquido = 0;

            var INSS = new CalculosINSS();
            calculo_INSS = INSS.CalculoINSS(Convert.ToDecimal(renda));

            var salario = new Salario();
            calculo_IMP = salario.CalcularDescontoDependentes(Convert.ToDecimal(renda), dependentes);

            var IRRF = new CalculoIRRF();
            resultado = IRRF.CalcularIRRF(renda, dependentes);

            liquido = salario.CalculoRendaLiquida(renda, resultado, calculo_INSS);

            Console.WriteLine("\nO Imposto INSS a ser aplicado e de: " +Convert.ToString(calculo_INSS));
            Console.WriteLine("O Imposto IMP a ser aplicado com a deducao de dependentes e de: " +Convert.ToString(resultado));
            Console.WriteLine("O Salario liquido a ser recebido e de: " +Convert.ToString(liquido));
            Console.ReadKey();

        }
    }
}