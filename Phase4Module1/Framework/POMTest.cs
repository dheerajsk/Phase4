using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace Phase4Module1.Framework
{
    [TestClass]
    public class POMTest
    {
        [TestMethod]
        public void Test_Home()
        {
            using (var driver = new ChromeDriver())
            {
                HomePOM pom = new HomePOM(driver);
                pom.GotoPage();
                Assert.IsTrue(driver.PageSource.Contains(pom.Title));
            }
        }
    }
}
