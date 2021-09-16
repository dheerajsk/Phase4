using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Phase4Module1
{
    [TestClass]
    public class SeleniumBasic
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.simplilearn.com");
                new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                var loginBtn = driver.FindElementByClassName("login");
                Assert.IsNotNull(loginBtn);

                loginBtn.Click();
                var title = driver.PageSource.Contains("Learning on Classroom");
                Assert.IsTrue(title);
            }
        }
    }
}
