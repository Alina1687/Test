using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Test2
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }

    //[Binding]  
    public class Hooks
    {
        private BrowserType _browserType;
        protected static IWebDriver Driver;


        [BeforeScenario]
        public void BeforeScenario()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
            if (Driver is null)
            {
                ChooseDriverInstance(_browserType);
                Driver.Manage().Window.Maximize();
            }
            Driver.Navigate().GoToUrl("https://www.nobilacasa.ro");
        }

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (!(Driver is null))
            {
                Driver.Quit();
                Driver = null;
            }
        }
    }
}
