using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

/// <summary>
/// This file is contains all the library methods used to interact with the elements on the webpage.
/// It contains methods to find element, wait, click, enter text and so on.
/// </summary>
namespace WestpacBDDFramework.Pages
{
    public class BasePage
    {
        private static IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static IWebElement FindElement(By locator, bool visibility = true)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));

            if (visibility)
            {
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            }
            else
            {
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            }
        }
        public static IWebElement WaitForElementToBeClickable(By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));

            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
        public static void ClickElement(By by)
        {
            IWebElement element = WaitForElementToBeDisplayed(by, 5);
            element.Click();
        }

        public static IWebElement WaitForElementToBeDisplayed(By by, int seconds)
        {
            try
            {
                var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, seconds));
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                return element;
            }
            catch (ElementNotVisibleException e)
            {
                Console.WriteLine("Element cannot be displayed on the webpage: " + e.Message);
                return null;
            }
        }
        public static void EnterText(By by, string text)
        {
            IWebElement element = WaitForElementToBeDisplayed(by, 5);
            element.Clear();
            element.SendKeys(text);
        }

        public static void EnterIntText(By by, int number)
        {
            IWebElement element = WaitForElementToBeDisplayed(by, 5);
            element.Clear();
            element.SendKeys(number.ToString());
        }

        public static string GetPageTitle()
        {
            return _driver.Title;
        }

        public static string GetPageUrl()
        {
            return _driver.Url;
        }

        public static string GetPageSource()
        {
            return _driver.PageSource;
        }
        public static void AssertText(By by, string expectedText)
        {
            IWebElement element = WaitForElementToBeDisplayed(by, 5);
            string actualText = element.Text;
            Assert.AreEqual(actualText, expectedText);
        }
        public static List<string> LoadCsvFile()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestData\ProfileData.csv");
            var reader = new StreamReader(File.OpenRead(path));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }

        public static void SelectComboBox(By by)
        {
            IWebElement element = WaitForElementToBeDisplayed(by, 5);
            element.Click();
            element.SendKeys(Keys.ArrowDown);
            element.SendKeys(Keys.Enter);
        }

    }
}
