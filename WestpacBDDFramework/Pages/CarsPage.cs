using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WestpacBDDFramework.Pages
{
    public class CarsPage : BasePage
    {
        // Elements in the Car links page 

        private readonly By _PopularMakeLink = By.XPath("//a[@href='/make/c0bm09bgagshpkqbsuag']");
        private readonly By _lamborghiniDiabloLink = By.XPath("//a[@href='/model/c0bm09bgagshpkqbsuag|c0bm09bgagshpkqbsuh0']");
        private readonly By _registeredModelsLink = By.XPath("//a[@href='/overall']");
        public CarsPage(IWebDriver driver): base(driver)
        {
        }
        public void CarsAreVisible()
        {
            WaitForElementToBeDisplayed(_PopularMakeLink, 5);
            WaitForElementToBeDisplayed(_lamborghiniDiabloLink, 5);
            WaitForElementToBeDisplayed(_registeredModelsLink, 5);
        }
        public void ClickPopularMake()
        {
            ClickElement(_PopularMakeLink);
        }
        public void ClickLamborghiniDiablo()
        {
            ClickElement(_lamborghiniDiabloLink);
        }
        public void ClickRegisterModelsLink()
        {
            ClickElement(_registeredModelsLink);
        }



    }
}
