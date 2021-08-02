using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class LoginSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private LoginPage loginPage;
        public LoginSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            loginPage = new LoginPage(driver);
            _context = context;
        }

        [When(@"I enter (.*), (.*)")]
        public void WhenIEnterUserNamePassword(string userName, string password)
        {
            loginPage.EnterUserName(userName);
            loginPage.EnterPassword(password);
        }

        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            loginPage.ClickLogin();
        }

    }
}
