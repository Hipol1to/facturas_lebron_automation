using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EncioEvents.StepDefinitions
{
    [Binding]
    public class Validate_LogInStepDefinitions
    {
        private IWebDriver driver;
        private string LoginUrl = "http://localhost/logincrud/login.php";
        public Validate_LogInStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user navigates to login web form")]
        public void GivenUserNavigatesToLoginWebForm()
        {
            this.driver.Navigate().GoToUrl(LoginUrl);
        }

        [When(@"user types the correct credentials")]
        public void WhenUserTypesTheCorrectCredentials()
        {
            By usernameInput = By.XPath("//*[@id=\"username\"]");
            driver.FindElement(usernameInput).Click();
            driver.FindElement(usernameInput).SendKeys("sober");

            By passwordInput = By.XPath("//*[@id=\"password\"]");
            driver.FindElement(passwordInput).Click();
            driver.FindElement(passwordInput).SendKeys("qqqq");

            By logInButton = By.XPath("/html/body/div[2]/div/form/div[4]/div/input");
            driver.FindElement(logInButton).Click();
        }

        [Then(@"user should be in main screen")]
        public void ThenUserShouldBeInMainScreen()
        {
            By logOutButton = By.XPath("/html/body/section[1]/div/div[1]/div/div/p/a[2]");
            Assert.IsNotNull(driver.FindElement(logOutButton));
            driver.Close();
            driver.Dispose();
        }
    }
}
