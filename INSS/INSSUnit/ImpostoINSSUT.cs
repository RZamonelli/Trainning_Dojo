using System;
using INSS.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace INSSUnit
{
    [TestClass]
    public class ImpostoINSSUT    
    {


        [TestMethod]
        public void TestINSSFaixa1()
        {
            var ImpostoINSS1 = new ImpostoINSS.FaixaINSS1();

            decimal ValorFaixa1 = ImpostoINSS1.CalcularINSS(1300.00m);

            Assert.AreEqual(104m, ValorFaixa1);
        }

        [TestMethod]
        public void TestINSSFaixa2()
        {
            var ImpostoINSS2 = new ImpostoINSS.FaixaINSS2();

            decimal ValorFaixa2 = ImpostoINSS2.CalcularINSS(2330.00m);

            Assert.AreEqual(209.70m, ValorFaixa2);
        }

        [TestMethod]
        public void TestINSSFaixa3()
        {
            var ImpostoINSS3 = new ImpostoINSS.FaixaINSS3();

            decimal ValorFaixa3 = ImpostoINSS3.CalcularINSS(2900.00m);

            Assert.AreEqual(319.00m, ValorFaixa3);
        }
    }
}
