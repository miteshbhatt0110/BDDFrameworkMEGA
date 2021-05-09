using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WestpacBDDFramework.Pages
{
    public class HomePage : BasePage
    {
        private readonly By _registerButton = By.XPath("//a[@href='/register']");
        private readonly By _userNameText = By.Name("login");
        private readonly By _password = By.Name("password");
        private readonly By _loginButton = By.XPath("//button[text()='Login']");
        private readonly By _welcomeMesssageLabel = By.CssSelector(".nav-link.disabled");
        private readonly By _invalidLoginMessage = By.CssSelector(".label.label-warning");
        private readonly By _profilelink = By.XPath("//a[@href='/profile']");

        public HomePage(IWebDriver driver): base(driver)
        {
        }
        public void ClickRegister()
        {
            ClickElement(_registerButton);
        }
        public void EnterUserName(string value)
        {
            EnterText(_userNameText, value);
        }
        public void EnterPassword(string value)
        {
            EnterText(_password, value);
        }
        public void ClickLogin()
        {
            ClickElement(_loginButton);
        }
        public void AssertWelcomeMessage(string value)
        {
            AssertText(_welcomeMesssageLabel, value);
        }
        public void AssertInvalidLogin(string value)
        {
            AssertText(_invalidLoginMessage, value);
        }
        public void ClickProfile()
        {
            ClickElement(_profilelink);
        }
    }
}
