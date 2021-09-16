using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Phase4Module1.Framework
{
    public class HomePOM
    {
        private IWebDriver driver;

        public string Title = "Learning";

        public HomePOM(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        public void GotoPage()
        {
            driver.Navigate().GoToUrl("https://www.simplilearn.com");
        }
    }
}
