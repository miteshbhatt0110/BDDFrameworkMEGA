using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WestpacBDDFramework.Pages
{
    public class ProfilePage : BasePage
    {
        // Elements in the Edit profile page

        private readonly By _userNameTextbox = By.Id("username");
        private readonly By _firstNameTextbox = By.Id("firstName");
        private readonly By _lastNameTextbox = By.Id("lastName");
        private readonly By _genderDropDown = By.Id("gender");
        private readonly By _ageTextbox = By.Id("age");
        private readonly By _addressTextarea = By.Id("address");
        private readonly By _phoneTextbox = By.Id("phone");
        private readonly By _hobbyDropDown = By.Id("hobby");
        private readonly By _currentPassword = By.Id("currentPassword");
        private readonly By _newPassword = By.Id("newPassword");
        private readonly By _confirmPassword = By.Id("newPasswordConfirmation");
        private readonly By _languageDropDown = By.Id("language");
        private readonly By _saveButton = By.CssSelector(".btn.btn-default");
        private readonly By _profileSaveSuccessfulMessage = By.CssSelector(".result.alert.alert-success");

        public ProfilePage(IWebDriver driver) : base(driver)
        {
        }
        public List<By> GetProfilePageElements()
        {
            List<By> profilePageElements = new List<By>
            {
                _userNameTextbox,
                _firstNameTextbox,
                _lastNameTextbox,
                _genderDropDown,
                _ageTextbox,
                _addressTextarea,
                _phoneTextbox,
                _hobbyDropDown,
                _currentPassword,
                _newPassword,
                _confirmPassword,
                _languageDropDown
            };
            return profilePageElements;
        }
        public void SelectGender(string value)
        {
            SelectComboBox(_genderDropDown);
        }
        public void EnterAge(int value)
        {
            EnterIntText(_ageTextbox, value);
        }
        public void EnterAddress(string value)
        {
            EnterText(_addressTextarea, value);
        }
        public void EnterPhone(string value)
        {
            EnterText(_phoneTextbox, value);
        }
        public void EnterHobby(string value)
        {
            SelectComboBox(_hobbyDropDown);
        }
        public void ClickSave()
        {
            ClickElement(_saveButton);
        }
        public void AssertProfileSuccessfulMessage(string value)
        {
            AssertText(_profileSaveSuccessfulMessage, value);
        }
        public string ValidateUserName(string value)
        {
            IWebElement element = WaitForElementToBeDisplayed(_userNameTextbox, 5);
            string actualText = element.GetAttribute("value");
            return actualText;
        }
        public string ValidateFirstName(string value)
        {
            IWebElement element = WaitForElementToBeDisplayed(_firstNameTextbox, 5);
            string actualText = element.Text;
            return actualText;
        }
        public string ValidateLastName(string value)
        {
            IWebElement element = WaitForElementToBeDisplayed(_lastNameTextbox, 5);
            string actualText = element.Text;
            return actualText;
        }
    }
}
