using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitLab
{
    [TestClass]
    public class BasicAssertion
    {
        [TestMethod]
        public void Test()
        {
            int number1 = 10;
            int number2 = 20;
            int number3 = -10;

            Assert.AreNotSame(number1, number3);
            Assert.IsFalse(number2 > 50);
            Assert.AreNotEqual(number3, number2);
        }
    }
}
