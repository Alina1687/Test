using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    class BasePage 
    {
        public readonly string NobilaUrl = "https://www.nobilacasa.ro/";
       // private IWebDriver _driver;
        public IWebDriver _driver;
        public BasePage(IWebDriver driver) => _driver = driver;


        //public BasePage()
        //{
        //    _driver = driver;
        //}
        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }

    }
    
}
