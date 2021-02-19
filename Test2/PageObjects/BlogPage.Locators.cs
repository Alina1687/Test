using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    partial class BlogPage
    {
         private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public BlogPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();

        }
        
        public IWebElement AboutUS => _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.wrapper > div > div.main-container.col2-right-layout > div > div.row > div.col-right.sidebar.sidebar.col-xs-12.col-md-3 > div > div.about-us.section > a")));

    }
}
