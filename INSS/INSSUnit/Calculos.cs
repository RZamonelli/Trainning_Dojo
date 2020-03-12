using System;
using INSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSSUnit
{
    [TestClass]
    public class Calculos
    {
        [TestMethod]
        public void TestMethod1()
        {
            var irrf = new CalculoIRRF();
            var imposto = irrf.CalcularIRRF(3000m, 2);

            Assert.AreEqual(196.56150m, imposto);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var irrf = new CalculoIRRF();
            var aliquota = irrf.CalcularRendaLiquida(3000m, 2);

            Assert.AreEqual(2620.82m, aliquota);
        }
    }
}
