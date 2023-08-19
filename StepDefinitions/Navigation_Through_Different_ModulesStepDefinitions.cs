using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace FacturasLebron.StepDefinitions
{
    [Binding]
    public class Navigation_Through_Different_ModulesStepDefinitions
    {
        private IWebDriver driver;
        private string LoginUrl = "http://localhost/facturaslebron/login.php";
        public Navigation_Through_Different_ModulesStepDefinitions (IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"a logged-in user")]
        public void GivenALogged_InUser()
        {
            this.driver.Navigate().GoToUrl(LoginUrl);

            By usernameInput = By.XPath("/html/body/div/div/form/input[1]");
            driver.FindElement(usernameInput).Click();
            driver.FindElement(usernameInput).SendKeys("admin");

            By passwordInput = By.XPath("/html/body/div/div/form/input[2]");
            driver.FindElement(passwordInput).Click();
            driver.FindElement(passwordInput).SendKeys("admin");

            By logInButton = By.XPath("//*[@id=\"submit\"]");
            driver.FindElement(logInButton).Click();

            By logOutButton = By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[2]/li/a");
            Assert.IsNotNull(driver.FindElement(logOutButton));
        }

        [When(@"the user clicks on the '([^']*)' module shortcut")]
        public void WhenTheUserClicksOnTheModuleShortcut(string module)
        {
            switch (module)
            {
                case "Clients":
                    By clientsButton = By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[3]/a");
                    driver.FindElement(clientsButton).Click();
                    break;
                case "Products":
                    By productsButton = By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[2]/a");
                    driver.FindElement(productsButton).Click();
                    break; 
                default:
                    break;
            }
        }

        [Then(@"the user is taken to the Clients module page")]
        public void ThenTheUserIsTakenToTheClientsModulePage()
        {
            By clientsTitle = By.XPath("/html/body/div[1]/div/div[1]/h4");
            Assert.IsNotNull(driver.FindElement(clientsTitle));
        }

        [Then(@"the user is taken to the Products module page")]
        public void ThenTheUserIsTakenToTheProductsModulePage()
        {
            By productsTitle = By.XPath("/html/body/div[1]/div/div[1]/h4");
            Assert.IsNotNull(driver.FindElement(productsTitle));
        }
    }
}
