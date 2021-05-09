using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class RegistrationSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private HomePage homePage;
        private RegistrationPage registrationPage;
        public RegistrationSteps(IWebDriver driver, ScenarioContext context) : base(driver) 
        {
            homePage = new HomePage(driver);
            registrationPage = new RegistrationPage(driver);
            _context = context;
        }

        [When(@"I click on the Register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            homePage.ClickRegister();  
        }

        [When(@"I type registration details for the user (.*), (.*), (.*), (.*), (.*)")]
        public void WhenIEnterRegistrationDetailsForTheUser(string userName, string firstName, string lastName, string Password, string confirmPassword)
        {
            registrationPage.EnterUserName(userName);
            registrationPage.EnterFirstName(firstName);
            registrationPage.EnterLastName(lastName);
            registrationPage.EnterPassword(Password);
            registrationPage.EnterConfirmPassword(confirmPassword);
        }

        [When(@"I click on Register")]
        public void WhenIClickOnRegister()
        {
            registrationPage.ClickRegister();
        }

        [Then(@"I should see Registration Successful message")]
        public void ThenIShouldSeeRegistrationSuccessfulMessage()
        {
            string expectedMessage = "Registration is successful";
            registrationPage.AssertSuccessMessage(expectedMessage);
        }

        [Then(@"I should see Username already exists message")]
        public void ThenIShouldSeeUsernameAlreadyExistsMessage()
        {
            string expectedMessage = "UsernameExistsException: User already exists";
            registrationPage.AssertFailureMessage(expectedMessage);
        }


    }
}
