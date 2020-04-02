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
            var msgApp = new MensagemAplicacao();
            bool resultado = msgApp.ValidaDependentes("A");

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void TestDependentesNoNegative()
        {
            var msgApp = new MensagemAplicacao();
            bool resultado = msgApp.ValidaDependentes("-1");

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void TestDependentesNoPositive()
        {
            var msgApp = new MensagemAplicacao();
            bool resultado = msgApp.ValidaDependentes("1");

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestINSS4000()
        {
            var inss = new CalculosINSS();
            decimal resultado = inss.CalculoINSS(4000m);

            Assert.AreEqual(440m, resultado);
        }

        [TestMethod]
        public void TestIRRF4000()
        {
            var irrf = new CalculoIRRF();
            decimal resultado = irrf.CalcularIRRF(4000m, 0);

            Assert.AreEqual(1100m, resultado);
        }

        [TestMethod]
        public void TestSalarioLiquido4000()
        {
            var salario = new Salario();
            decimal resultado = salario.CalculoRendaLiquida(4000m, 1100m, 440m);

            Assert.AreEqual(2460m, resultado);
        }

    }
}