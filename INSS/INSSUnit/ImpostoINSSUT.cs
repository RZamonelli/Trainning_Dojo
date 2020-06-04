using System;
using INSS;
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
            var ImpostoINSS = new ImpostoINSS();

            decimal Aliquota1 = ImpostoINSS.GetAliquotaINSS(1399.10m);
            decimal Aliquota2 = ImpostoINSS.GetAliquotaINSS(2300.11m);
            decimal Aliquota3 = ImpostoINSS.GetAliquotaINSS(2500.10m);

            Assert.Equals(Aliquota1, ConstantINSS.INSS008);
            Assert.Equals(Aliquota2, ConstantINSS.INSS009);
            Assert.Equals(Aliquota3, ConstantINSS.INSS011);

        }

        [TestMethod]
        public void TestCalculoImpostoInss()
        {
            var ImpostoINSS = new ImpostoINSS();

            decimal ValorInssTest1 = ImpostoINSS.GetAliquotaINSS(1300.00m);
            decimal ValorInssTest2 = ImpostoINSS.GetAliquotaINSS(2330.00m);
            decimal ValorInssTest3 = ImpostoINSS.GetAliquotaINSS(2900.00m);

            Assert.Equals(ValorInssTest1, 104.00m);
            Assert.Equals(ValorInssTest2, 207.07m);
            Assert.Equals(ValorInssTest3, 319.00m);

        }
    }
}
