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
            var test = new Class1().Teste();

            Assert.AreEqual("", test);
        }
    }
}
