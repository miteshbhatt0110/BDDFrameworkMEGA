using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class BackgroundSteps : BaseSteps
    {
        public BackgroundSteps(IWebDriver driver) : base(driver)
        {            
        }
        [Given(@"I navigate to Buggy Cars website")]
        public void GivenINavigateToBuggyCarsWebsite()
        {
            _driver.Navigate().GoToUrl("https://buggy.justtestit.org/");
        }

    }
}
