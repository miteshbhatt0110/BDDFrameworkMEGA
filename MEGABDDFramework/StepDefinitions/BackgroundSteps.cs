using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class BackgroundSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private LoginPage loginPage;
        private FileManagerPage fileManagerPage;
        public BackgroundSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            loginPage = new LoginPage(driver);
            fileManagerPage = new FileManagerPage(driver);
            _context = context;
        }
        [Given(@"I navigate to mega website")]
        public void GivenINavigateToMegaWebsite()
        {
            _driver.Navigate().GoToUrl("https://mega.nz/");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Accept All Cookies']"))).Click();
            _driver.SwitchTo().DefaultContent();
        }

        [Then(@"I should be navigated to the File Manager page")]
        public void ThenIShouldBeNavigatedToTheFileManagerPage()
        {
            foreach (By field in fileManagerPage.GetFileManagerPageElements())
            {
                BasePage.WaitForElementToBeDisplayed(field, 5);
            }
        }

        [Given(@"I enter my user credentials and login")]
        public void GivenIEnterMyUserCredentialsAndLogin()
        {
            loginPage.ClickLogin();
            List<string> profileData = BasePage.LoadCsvFile();
            foreach (string data in profileData)
            {
                string[] profileDataToEnter = data.Split(", ");
                loginPage.EnterUserName(profileDataToEnter[0].ToString());
                loginPage.EnterPassword(profileDataToEnter[1].ToString());
                loginPage.ClickLoginOnPopUp();
            }
        }
    }
}
