using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EncioEvents.StepDefinitions
{
    [Binding]
    public class Validate_Last_EventsStepDefinitions
    {
        private IWebDriver driver;
        private string LoginUrl = "http://localhost/logincrud/login.php";
        public Validate_Last_EventsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"user log in with valid credentials")]
        public void GivenUserLogInWithValidCredentials()
        {
            this.driver.Navigate().GoToUrl(LoginUrl);
        }

        [Given(@"user is on main screen")]
        public void GivenUserIsOnMainScreen()
        {
            By usernameInput = By.XPath("//*[@id=\"username\"]");
            driver.FindElement(usernameInput).Click();
            driver.FindElement(usernameInput).SendKeys("sober");

            By passwordInput = By.XPath("//*[@id=\"password\"]");
            driver.FindElement(passwordInput).Click();
            driver.FindElement(passwordInput).SendKeys("qqqq");

            By logInButton = By.XPath("/html/body/div[2]/div/form/div[4]/div/input");
            driver.FindElement(logInButton).Click();

            By logOutButton = By.XPath("/html/body/section[1]/div/div[1]/div/div/p/a[2]");
            Assert.IsNotNull(driver.FindElement(logOutButton));
        }

        [When(@"look for last events section")]
        public void WhenLookForLastEventsSection()
        {
            By lastEvents = By.XPath("/html/body/section[2]/div/div[1]/div/div/h2");
            driver.FindElement(lastEvents);
        }

        [Then(@"last events section should be visible")]
        public void ThenLastEventsSectionShouldBeVisible()
        {
            By lastEvents = By.XPath("/html/body/section[2]/div/div[1]/div/div/h2");
            driver.FindElement(lastEvents);
            Assert.IsNotNull(driver.FindElement(lastEvents));
        }

        [Then(@"shoul have event photo and description")]
        public void ThenShoulHaveEventPhotoAndDescription()
        {
            By eventOnePhoto = By.XPath("/html/body/section[2]/div/div[2]/div[1]/div/div/div[1]/a/img");
            driver.FindElement(eventOnePhoto);
            Assert.IsNotNull(driver.FindElement(eventOnePhoto));
            By eventOneDescription = By.XPath("/html/body/section[2]/div/div[2]/div[1]/div/div/div[2]/h3/a");
            driver.FindElement(eventOneDescription);
            Assert.IsNotNull(driver.FindElement(eventOneDescription));

            By eventTwoPhoto = By.XPath("/html/body/section[2]/div/div[2]/div[2]/div/div/div[1]/a/img");
            driver.FindElement(eventTwoPhoto);
            Assert.IsNotNull(driver.FindElement(eventTwoPhoto));
            By eventTwoDescription = By.XPath("/html/body/section[2]/div/div[2]/div[2]/div/div/div[2]/h3");
            driver.FindElement(eventTwoDescription);
            Assert.IsNotNull(driver.FindElement(eventTwoDescription));

            By eventThreePhoto = By.XPath("/html/body/section[2]/div/div[2]/div[3]/div/div/div[1]/a/img");
            driver.FindElement(eventThreePhoto);
            Assert.IsNotNull(driver.FindElement(eventThreePhoto));
            By eventThreeDescription = By.XPath("/html/body/section[2]/div/div[2]/div[3]/div/div/div[2]/h3/a");
            driver.FindElement(eventThreeDescription);
            Assert.IsNotNull(driver.FindElement(eventThreeDescription));
        }
    }
}
