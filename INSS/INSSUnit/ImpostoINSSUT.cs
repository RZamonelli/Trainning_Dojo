using System;
using INSS.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace INSSUnit
{
    [TestClass]
    public class ImpostoINSSUT    
    {
        

        [TestMethod]
        public void TestGetAliquota()
        {
            var ImpostoINSS = new ImpostoINSS.ImpostoINSS();

            decimal Aliquota1 = ImpostoINSS.GetAliquotaINSS(1399.10m);
            decimal Aliquota2 = ImpostoINSS.GetAliquotaINSS(2300.11m);
            decimal Aliquota3 = ImpostoINSS.GetAliquotaINSS(2500.10m);

            Assert.AreEqual(ConstantINSS.INSS008, Aliquota1);
            Assert.AreEqual(ConstantINSS.INSS009, Aliquota2);
            Assert.AreEqual(ConstantINSS.INSS011, Aliquota3);

        }

        [TestMethod]
        public void TestCalculoImpostoInss()
        {
            var ImpostoINSS = new ImpostoINSS.ImpostoINSS();

            decimal ValorInssTest1 = ImpostoINSS.CalcularInss(1300.00m);
            decimal ValorInssTest2 = ImpostoINSS.CalcularInss(2330.00m);
            decimal ValorInssTest3 = ImpostoINSS.CalcularInss(2900.00m);

            Assert.AreEqual(104.00m, ValorInssTest1);
            Assert.AreEqual(209.70m, ValorInssTest2);
            Assert.AreEqual(319.00m, ValorInssTest3);

        }
    }
}
