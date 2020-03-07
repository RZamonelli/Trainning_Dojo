using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            double renda = 0, calculo_INSS = 0, calculo_IMP = 0, resultado = 0, liquido = 0;
            int dependentes = 0;
            int i, x, z;

            Console.WriteLine("CALCULADORA PARA CALCULAR O IMPOSTO DE RENDA - PADRAO: ");
            Console.WriteLine("DIGITE A RENDA MENSAL BRUTA: ");
            renda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE O NUMERO DE DEPENDENTES: ");
            dependentes = Convert.ToInt32(Console.ReadLine());

            if (renda <= 1399.12)
            {
                calculo_INSS = renda * 0.08;
            }
            if (renda >= 1399.13 && renda <= 2331.88)
            {
                calculo_INSS = renda * 0.09;
            }
            else
            {
                calculo_INSS = renda * 0.11;
            }
            calculo_IMP = (renda - (dependentes * 189.59));
            if (calculo_IMP <= 1903.98)
            {
                resultado = 0;
            }
            else
            if (calculo_IMP >= 1903.08 && calculo_IMP <= 2826.65)
            {
                resultado = calculo_IMP * 0.075;
            }
            else
            if (calculo_IMP >= 2826.65 && calculo_IMP <= 3751.05)
            {
                resultado = calculo_IMP * 0.15;
            }
            else
            if (calculo_IMP >= 3751.05 && calculo_IMP <= 4664.68)
            {
                resultado = calculo_IMP * 0.275;
            }

            liquido = renda - resultado - calculo_INSS;
            Console.WriteLine("\nO Imposto INSS a ser aplicado e de: " +Convert.ToString(calculo_INSS));
            Console.WriteLine("O Imposto IMP a ser aplicado com a deducao de dependentes e de: " +Convert.ToString(resultado));
            Console.WriteLine("O Salario liquido a ser recebido e de: " +Convert.ToString(liquido));
            Console.ReadKey();

        }
    }
}
