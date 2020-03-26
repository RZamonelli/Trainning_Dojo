using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace INSS
{
    public class MensagemAplicacao
    {
        public void IniciarAplicacao()
        {
            decimal renda = 0;
            int dependentes = 0;

            Console.WriteLine("CALCULADORA PARA CALCULAR O IMPOSTO DE RENDA - PADRAO: ");

            Console.WriteLine("DIGITE A RENDA MENSAL BRUTA: ");
            renda = Convert.ToDecimal(Console.ReadLine());

            dependentes = LerDependentes();
        }

        public bool ValidaDependentes(string dependentes)
        {
            Regex rgx = new Regex(@"^[0-9]$");
            return rgx.IsMatch(dependentes);
        }

        public int LerDependentes()
        {
            var dependentes = "";
            Console.WriteLine("DIGITE O NUMERO DE DEPENDENTES: ");
            dependentes = Console.ReadLine();

            while (!ValidaDependentes(dependentes))
            {
                Console.WriteLine("INPUT INCORRETO, FAVOR INFORMAR NOVAMENTE!");
            }
            return int.Parse(dependentes);
        }
    }
}