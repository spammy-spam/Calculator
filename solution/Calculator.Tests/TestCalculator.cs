using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculo.Calculator.Tests
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Calculator.Library.Calculator.Test(true));
        }
    }
}
