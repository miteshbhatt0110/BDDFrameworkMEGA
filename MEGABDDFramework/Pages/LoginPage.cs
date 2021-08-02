using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WestpacBDDFramework.Pages
{
    public class LoginPage : BasePage
    {
        // Elements in the home page 

        private readonly By _emailText = By.Id("login-name2");
        private readonly By _password = By.Id("login-password2");
        private readonly By _loginButton = By.XPath("//span[text()='Login']");
        private readonly By _loginPopUp = By.XPath("//div[contains(@class,'login-popup')]");
        private readonly By _loginPopUpButton = By.XPath("//span[text()='Log in']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public void ClickLoginButton()
        {
            ClickElement(_loginButton);
        }
        public void EnterUserName(string value)
        {
            EnterText(_emailText, value);
        }
        public void EnterPassword(string value)
        {
            EnterText(_password, value);
        }
        public void ClickLogin()
        {
            ClickElement(_loginButton);
        }
        public void ClickLoginOnPopUp()
        {
            ClickElement(_loginPopUpButton);
        }
    }
}
