using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {
        protected IWebDriver _driver;

        public BaseSteps(IWebDriver driver)
        {
            _driver = driver;
        }
       
    }
}
