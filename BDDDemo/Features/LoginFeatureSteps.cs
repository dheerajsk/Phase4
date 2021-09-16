using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Phase4Module1.Framework;
using TechTalk.SpecFlow;

namespace BDDDemo.Features
{
    [Binding]
    public class LoginFeatureSteps
    {
        private ChromeDriver driver;
        private IWebElement button;

        [Given(@"Our home page has login button")]
        public void GivenOurHomePageHasLoginButton()
        {
            driver = new ChromeDriver();
            HomePOM pom = new HomePOM(driver);
            pom.GotoPage();
            button = driver.FindElementByClassName("login");
            Assert.IsNotNull(button);
            ScenarioContext.Current["title"] = "Learning on Simplilearn";
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            button.Click();
        }

        [Then(@"Redirect to login page")]
        public void ThenRedirectToLoginPage()
        {
            var result = ScenarioContext.Current["title"];
            var title = driver.PageSource.Contains(result.ToString());
            Assert.IsTrue(title);
        }
    }
}
