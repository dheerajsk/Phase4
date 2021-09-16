using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Phase4Module1
{
    [TestClass]
    public class AdvanceAutomation
    {

        [TestMethod]
        public void Test_IFrame()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("file://C:/Users/kumardh/Documents/iframe.html");
                new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                var iframes = driver.FindElementsByTagName("iframe");
                Assert.AreEqual(iframes.Count, 2);

                driver.SwitchTo().Frame(0);
                var containData = driver.PageSource.Contains("Build fast, responsive sites with Bootstrap");
                Assert.IsTrue(containData);
            }
        }

        [TestMethod]
        public void Test_Screenshot()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.simplilearn.com");
                new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                ITakesScreenshot ssdriver = driver;
                Screenshot screenshot = ssdriver.GetScreenshot();
                screenshot.SaveAsFile("D:/test.png");
            }
        }
    }
}
