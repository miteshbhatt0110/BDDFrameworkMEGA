using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WestpacBDDFramework.Pages
{
    public class RegistrationPage : BasePage
    {
        private readonly By _loginTextbox = By.Id("username");
        private readonly By _firstNameTextbox = By.Id("firstName");
        private readonly By _lastNameTextbox = By.Id("lastName");
        private readonly By _passwordTextbox = By.Id("password");
        private readonly By _confirmPasswordTextbox = By.Id("confirmPassword");
        private readonly By _registerButton = By.XPath("//button[@type='submit' and text()='Register']");
        private readonly By _cancelButton = By.XPath("//a[text()='Cancel']");
        private readonly By _registrationSuccessfulMessage = By.XPath("//div[contains(text(),'Registration is successful')]");
        private readonly By _userExistsMessage = By.XPath("//div[contains(text(),'User already exists')]");
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }
        public void EnterUserName(string value)
        {
            EnterText(_loginTextbox, value);
        }
        public void EnterFirstName(string value)
        {
            EnterText(_firstNameTextbox, value);
        }
        public void EnterLastName(string value)
        {
            EnterText(_lastNameTextbox, value);
        }
        public void EnterPassword(string value)
        {
            EnterText(_passwordTextbox, value);
        }
        public void EnterConfirmPassword(string value)
        {
            EnterText(_confirmPasswordTextbox, value);
        }
        public void ClickRegister()
        {
            ClickElement(_registerButton);
        }
        public void AssertSuccessMessage(string value)
        {
            AssertText(_registrationSuccessfulMessage, value);
        }
        public void AssertFailureMessage(string value)
        {
            AssertText(_userExistsMessage, value);
        }

    }
}
