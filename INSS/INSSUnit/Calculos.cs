using System;
using INSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSSUnit
{
    [TestClass]
    public class Calculos
    {
        [TestMethod]
        public void TestINSS1300()
        {
            var inss = new CalculosINSS();
            decimal resultado = inss.CalculoINSS(1300m);

            Assert.AreEqual(143m, resultado);
        }

        [TestMethod]
        public void TestDependents1300()
        {
            var dependents = new Salario();
            decimal resultado = dependents.CalcularDescontoDependentes(1300m, 0);

            Assert.AreEqual(1300m, resultado);
        }

        [TestMethod]
        public void TestIRRF1300()
        {
            var irrf = new CalculoIRRF();
            decimal resultado = irrf.CalcularIRRF(1300m, 0);

            Assert.AreEqual(0m, resultado);
        }

        [TestMethod]
        public void TestSalarioLiquido1300()
        {
            var salario = new Salario();
            decimal resultado = salario.CalculoRendaLiquida(1300m, 0m, 143m);

            Assert.AreEqual(1157m, resultado);
        }

        [TestMethod]
        public void TestDependentesString()
        {
            var msgApp = new Aplicacao();
            bool resultado = msgApp.ValidaDependentes("A");

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void TestDependentesNoNegative()
        {
            var msgApp = new Aplicacao();
            bool resultado = msgApp.ValidaDependentes("-1");

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void TestDependentesNoPositive()
        {
            var msgApp = new Aplicacao();
            bool resultado = msgApp.ValidaDependentes("1");

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestINSS2000()
        {
            var inss = new CalculosINSS();
            decimal resultado = inss.CalculoINSS(2000m);

            Assert.AreEqual(180m, resultado);
        }

        [TestMethod]
        public void TestDependents2000()
        {
            var dependents = new Salario();
            decimal resultado = dependents.CalcularDescontoDependentes(2000m, 2);

            Assert.AreEqual(1620.82m, resultado);
        }

        [TestMethod]
        public void TestIRRF2000()
        {
            var irrf = new CalculoIRRF();
            decimal resultado = irrf.CalcularIRRF(2000m, 2);

            Assert.AreEqual(0m, resultado);
        }

        [TestMethod]
        public void TestSalarioLiquido2000()
        {
            var salario = new Salario();
            decimal resultado = salario.CalculoRendaLiquida(2000m, 2m, 180m);

            Assert.AreEqual(1818m, resultado);
        }
    }
}