﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace INSS
{
    public class Aplicacao
    {
        decimal renda = 0, calculo_INSS = 0, calculo_IMP = 0, calculo_IRRF = 0, salarioLiquido = 0;
        readonly CalculosINSS objINSS = null;
        readonly Remuneracao objSalario = null;
        readonly CalculoIRRF objIRRF = null;
        readonly Dependentes objDep = null;

        public Aplicacao()
        {
            objINSS = new CalculosINSS();
            //objIRRF = new CalculoIRRF();
            objSalario = new Remuneracao();
            objDep = new Dependentes();
        }

        private void CapturarInputs()
        {
            renda = LerRendaBruta();
            LerDependentes();
        }

        public bool ValidaDependentes(string dependentes)
        {
            Regex rgx = new Regex(@"^[0-9]$");
            return rgx.IsMatch(dependentes);
        }

        private void LerDependentes()
        {
            var dependentes = "";
            Console.WriteLine("DIGITE O NUMERO DE DEPENDENTES: ");
            dependentes = Console.ReadLine();

            while (!ValidaDependentes(dependentes))
            {
                Console.WriteLine("INPUT INCORRETO, FAVOR INFORMAR NOVAMENTE!");
            }
            objDep.LerDependentes(int.Parse(dependentes));
        }

        private decimal LerRendaBruta()
        {
            var renda = "";
            Console.WriteLine("DIGITE A RENDA MENSAL BRUTA: ");
            renda = Console.ReadLine();

            return decimal.Parse(renda);
        }

        public void Inicializar()
        {
            Console.WriteLine("CALCULADORA PARA CALCULAR O IMPOSTO DE RENDA - PADRAO: ");
            CapturarInputs();
        }

        public void Finalizar()
        {
            Console.WriteLine("\nO Imposto INSS a ser aplicado e de: " + Convert.ToString(calculo_INSS));
            Console.WriteLine("O Imposto IMP a ser aplicado com a deducao de dependentes e de: " + Convert.ToString(calculo_IRRF));
            Console.WriteLine("O Salario liquido a ser recebido e de: " + Convert.ToString(salarioLiquido));
            Console.ReadKey();
        }

        public void Calcular()
        {
            calculo_INSS = objINSS.CalculoINSS(Convert.ToDecimal(renda));

            calculo_IMP = objDep.CalcularDescontoDependentes(Convert.ToDecimal(renda));
            calculo_IRRF = objIRRF.CalcularIRRF(calculo_IMP);

            objSalario.LerRendaBruta(renda);
            salarioLiquido = objSalario.CalculoRendaLiquida();
        }
    }
}