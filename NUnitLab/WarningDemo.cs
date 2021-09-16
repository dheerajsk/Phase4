using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NUnitLab
{
    [TestClass]
    public class WarningDemo
    {
        [TestMethod]
        public void Test()
        {
            string name1 = "Jon";
            string name2 = "Doe";
            Warn.If(name1 != name2);
            Warn.If(1 == 1);
            //NUnit.Framework.Assert.Fail("Failed");
        }
    }
}
