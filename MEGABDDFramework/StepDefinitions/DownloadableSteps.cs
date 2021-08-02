using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;
namespace WestpacBDDFramework.StepDefinitions
{
    public class DownloadableSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private FileManagerPage fileManagerPage;
        private string enteredName = "MyTestFile";
        int valid_links = 0;
        int broken_links = 0;

        public DownloadableSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            fileManagerPage = new FileManagerPage(driver);
            _context = context;
        }

        [Given(@"I navigate mega sync webpage")]
        public void GivenINavigateMegaSyncWebpage()
        {
            _driver.Navigate().GoToUrl("https://mega.nz/sync");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Accept All Cookies']"))).Click();
            _driver.SwitchTo().DefaultContent();
        }

        [When(@"I click on Linux option at the bottom of the page")]
        public void WhenIClickOnLinuxOptionAtTheBottomOfThePage()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Linux')]"))).Click();
        }

        [Then(@"I should be able to download all the linux options")]
        public async System.Threading.Tasks.Task ThenIShouldBeAbleToDownloadAllTheLinuxOptionsAsync()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Linux Distro')]"))).Click();
            IReadOnlyCollection<IWebElement> downloadLinks = _driver.FindElements(By.XPath("//div[@class='mega-input-dropdown']//div[@class='option']"));
            using var client = new HttpClient();

            foreach (IWebElement link in downloadLinks)
            {
                string typeValue = link.GetAttribute("data-link");
                HttpResponseMessage response = await client.GetAsync(link.GetAttribute("data-link"));
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    valid_links++;
                }
                else
                {
                    broken_links++;
                }
            }
            Console.WriteLine("Detection of broken links completed with " + broken_links + " broken links and " + valid_links + " valid links");
        }

    }
}
