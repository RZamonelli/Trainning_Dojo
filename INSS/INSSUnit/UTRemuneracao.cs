using System;
using INSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSSUnit
{
    [TestClass]
    public class UTRemuneracao
    {
        [TestMethod]
        public void TestRemuneracao1300()
        {
            var salario = new Remuneracao();
            salario.LerRendaBruta(1300m);
            salario.ValorIRRF = 0m;
            salario.ValorINNS = 143m;
            decimal resultado = salario.CalculoRendaLiquida();

            Assert.AreEqual(1157m, resultado);
        }

        [TestMethod]
        public void TestRemuneracao2000()
        {
            var salario = new Remuneracao();
            salario.LerRendaBruta(2000m);
            salario.ValorIRRF = 2m;
            salario.ValorINNS = 180m;
            decimal resultado = salario.CalculoRendaLiquida();

            Assert.AreEqual(1818m, resultado);
        }

        [TestMethod]
        public void TestRemuneracao3000()
        {
            var salario = new Remuneracao();
            salario.LerRendaBruta(3000m);
            salario.ValorIRRF = 450m;
            salario.ValorINNS = 330m;
            decimal resultado = salario.CalculoRendaLiquida();
            Assert.AreEqual(2220m, resultado);

        }

        [TestMethod]
        public void TestRemuneracao4000()
        {
            var salario = new Remuneracao();
            salario.LerRendaBruta(4000m);
            salario.ValorIRRF = 1100m;
            salario.ValorINNS = 440m;
            decimal resultado = salario.CalculoRendaLiquida();

            Assert.AreEqual(2460m, resultado);
        }

        [TestMethod]
        public void TestRemuneracao4700()
        {
            var salario = new Remuneracao();
            salario.LerRendaBruta(4700m);
            salario.ValorIRRF = 0m;
            salario.ValorINNS = 517m;
            decimal resultado = salario.CalculoRendaLiquida();

            Assert.AreEqual(4183m, resultado);
        }
    }
}
