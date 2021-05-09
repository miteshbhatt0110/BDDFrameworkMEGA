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
        private HomePage homePage;
        private RegistrationPage registrationPage;
        public LoginSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            homePage = new HomePage(driver);
            registrationPage = new RegistrationPage(driver);
            _context = context;
        }

        [When(@"I enter (.*), (.*)")]
        public void WhenIEnterUserNamePassword(string userName, string password)
        {
            homePage.EnterUserName(userName);
            homePage.EnterPassword(password);
        }

        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            homePage.ClickLogin();
        }

        [Then(@"I should see welcome message '(.*)' on top of the page")]
        public void ThenIShouldSeeWelcomeMessageOnTopOfThePage(string welcomeMessage)
        {
            homePage.AssertWelcomeMessage(welcomeMessage);
        }

        [Then(@"I should see Invalid credentials message")]
        public void ThenIShouldSeeInvalidCredentialsMessage()
        {
            string expectedMessage = "Invalid username/password";
            homePage.AssertInvalidLogin(expectedMessage);
        }


    }
}
