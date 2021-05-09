using System;
using BoDi;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using System.Reflection;

namespace WestpacBDDFramework.Setup
{
    [Binding]
    public class DriverSetup
    {
        private IWebDriver _driver;
        private readonly IObjectContainer _container;
        private ScenarioContext _context;

        public DriverSetup(IObjectContainer container)
        {
            _container = container;
            _context = container.Resolve<ScenarioContext>();
        }
        [BeforeScenario]
        public void Initialize()
        {
            String browser = ConfigurationManager.AppSettings["browser"];
            _driver = GetDriver("CHROME");
            _driver.Manage().Window.Maximize();
        }

        public IWebDriver GetDriver(string requiredDriver)
        {
            switch (requiredDriver)
            {
                case "CHROME":
                    ChromeOptions chromeoptions = new ChromeOptions();
                    _driver = new ChromeDriver(chromeoptions);
                    _container.RegisterInstanceAs(_driver);
                    break;
                case "FIREFOX":
                    FirefoxOptions firefoxoptions = new FirefoxOptions();
                    _driver = new FirefoxDriver(firefoxoptions);
                    _container.RegisterInstanceAs(_driver);
                    break;
                case "IE":
                    InternetExplorerOptions ieoptions = new InternetExplorerOptions();
                    _driver = new InternetExplorerDriver(ieoptions);
                    _container.RegisterInstanceAs(_driver);
                    break;
            }
            return _driver;
        }

        [AfterScenario]
        public void DisposeDriver()
        {
            CaptureScreenshot();
            _driver.Close();
            _driver.Quit();
            _driver.Dispose();         
        }

        public void CaptureScreenshot()
        {
            Screenshot screenShotFile = ((ITakesScreenshot)_driver).GetScreenshot();
            string path = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                      @"\Screenshot" + "_" +
                      DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png");
            screenShotFile.SaveAsFile(path, ScreenshotImageFormat.Png);
        }
    }
}


