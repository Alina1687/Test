using BoDi;
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

    [Binding]  //daca nu creeaza 2 instante de browsere
    public sealed class Hooks
    {
        private BrowserType _browserType;
        public static IWebDriver _driver;
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        public void CreateDriver()
        {
             var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
           
             ChooseDriverInstance(_browserType);
              _driver.Manage().Window.Maximize();
        }
        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    CreateDriver();
        //    //var browserType = TestContext.Parameters.Get("Browser", "Chrome");
        //    //_browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
        //    //if (Driver is null)
        //    //{
        //    //    ChooseDriverInstance(_browserType);
        //    //    Driver.Manage().Window.Maximize();
        //    //}
        //    //Driver.Navigate().GoToUrl("https://www.nobilacasa.ro");
        //}

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    _driver = new ChromeDriver();
                    _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                    break;
                case BrowserType.Firefox:
                    _driver = new FirefoxDriver();
                    _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                    break;
            }
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            CreateDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
          //  if (!(Driver is null))
            {
                _driver.Quit();
                _driver = null;
            }
        }
    }
}
