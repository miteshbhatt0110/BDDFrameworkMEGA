using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class ProfileSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private HomePage homePage;
        private ProfilePage profilePage;
        public ProfileSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            homePage = new HomePage(driver);
            profilePage = new ProfilePage(driver);
            _context = context;
        }

        [When(@"I click Profile on the website navigation bar")]
        public void WhenIClickProfileOnTheWebsiteNavigationBar()
        {
            homePage.ClickProfile();
        }
        [Then(@"I should see Basic and Additional Info about my profile")]
        public void ThenIShouldSeeBasicAndAdditionalInfoAboutMyProfile()
        {
            foreach (By field in profilePage.GetProfilePageElements())
            {
                BasePage.WaitForElementToBeDisplayed(field, 5);
            }
        }
        [When(@"I enter my profile details")]
        public void WhenIEnterMyProfileDetails()
        {
            List<string> profileData = BasePage.LoadCsvFile();
            foreach (string data in profileData)
            {
                string[] profileDataToEnter = data.Split(", ");
                profilePage.ValidateUserName(profileDataToEnter[0].ToString());
                profilePage.ValidateFirstName(profileDataToEnter[1].ToString());
                profilePage.ValidateLastName(profileDataToEnter[2].ToString());
                profilePage.SelectGender(profileDataToEnter[3].ToString());
                int age = Convert.ToInt32(profileDataToEnter[4]);
                profilePage.EnterAge(age);
                profilePage.EnterAddress(profileDataToEnter[5].ToString());
                profilePage.EnterPhone(profileDataToEnter[6].ToString());
                profilePage.EnterHobby(profileDataToEnter[7].ToString());

            }
        }
        [When(@"I click on Save")]
        public void WhenIClickOnSave()
        {
            profilePage.ClickSave();
        }
        [Then(@"I should see the profile save is successful message")]
        public void ThenIShouldSeeTheProfileSaveIsSuccessfulMessage()
        {
            string expectedMessage = "The profile has been saved successful";
            profilePage.AssertProfileSuccessfulMessage(expectedMessage);
        }


    }
}
