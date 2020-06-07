using System;
using INSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSSUnit
{
    [TestClass]
    public class UTCalculoIRRF
    {
        [TestMethod]
        public void TestIRRFFaixaUm()
        {
            CalculoIRRF faixaIRRF = new FaixaUm();
            new Dependentes().LerDependentes(0);
            decimal rendaDependentes = new Dependentes().CalcularDescontoDependentes(190398m);

            decimal resultado = faixaIRRF.CalcularIRRF(rendaDependentes);

            Assert.AreEqual(0m, resultado);
        }

        [TestMethod]
        public void TestIRRFFaixaDois()
        {
            CalculoIRRF faixaIRRF = new FaixaDois();
            new Dependentes().LerDependentes(0);
            decimal rendaDependentes = new Dependentes().CalcularDescontoDependentes(190399m);

            decimal resultado = faixaIRRF.CalcularIRRF(rendaDependentes);

            Assert.AreEqual(14279.92500m, resultado);
        }

        [TestMethod]
        public void TestIRRFFaixaTres()
        {
            CalculoIRRF faixaIRRF = new FaixaTres();
            new Dependentes().LerDependentes(0);
            decimal rendaDependentes = new Dependentes().CalcularDescontoDependentes(282665m);

            decimal resultado = faixaIRRF.CalcularIRRF(rendaDependentes);

            Assert.AreEqual(42399.7500m, resultado);
        }

        [TestMethod]
        public void TestIRRFFaixaQuatro()
        {
            CalculoIRRF faixaIRRF = new FaixaQuatro();
            new Dependentes().LerDependentes(0);
            decimal rendaDependentes = new Dependentes().CalcularDescontoDependentes(375105m);

            decimal resultado = faixaIRRF.CalcularIRRF(rendaDependentes);

            Assert.AreEqual(103153.87500M, resultado);
        }
    }
}
