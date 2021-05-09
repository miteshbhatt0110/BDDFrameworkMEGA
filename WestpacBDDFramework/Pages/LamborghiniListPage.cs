using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WestpacBDDFramework.Pages
{
    public class LamborghiniListPage : BasePage
    {
        // Elements in the Lamborghini Page when the Popular links is clicked

        private readonly By _lamborghiniImage = By.XPath("//img[@src='/img/header-car.gif']");
        private readonly By _lamborghiniDescription = By.XPath("//div[@class='col-md-9']");
        private readonly By _listOfModels = By.CssSelector(".cars.table.table-hover");
        public LamborghiniListPage(IWebDriver driver) : base(driver)
        {
        }

        public List<By> GetLaborghiniPageElements()
        {
            List<By> lamborghiniPageElements = new List<By>
            {
                _lamborghiniImage,
                _lamborghiniDescription,
                _listOfModels
            };
            return lamborghiniPageElements;
        }
        public By ClickCarName(string carName)
        {
            By carNameLink =  By.XPath($"//a[text()='{carName}']");
            ClickElement(carNameLink);
            return carNameLink;
        }
    }
}
