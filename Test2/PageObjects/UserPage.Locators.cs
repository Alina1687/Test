using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
   partial class UserPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        //public UserPage(IWebDriver driver)
        //{
        //    _driver = driver;
        //    _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        //    _driverWait.IgnoreExceptionTypes();

        //}
        public UserPage(IWebDriver driver) => _driver = driver;

        private IWebElement DateleMele => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[1]/div/div/ul/li[1]"));
        private IWebElement Modifica => _driver.FindElement(By.CssSelector("body > div.wrapper > div > div.main-container.col2-left-layout > div > div.row > div.col-main.col-xs-12.col-md-9 > div > div > div:nth-child(3) > div.section-content > ul > li > button.button.button-modify.f-right.waves-effect.waves-light"));
        // private IWebElement PozaProfil => _driver.FindElement(By.CssSelector("//a [text()='Poză Profil']"));
        private IWebElement PozaProfil => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[1]/div/div/ul/li[4]"));
        public IWebElement IncarcaButton => _driver.FindElement(By.CssSelector("//button[@title='Încarcă']"));
        public IWebElement ComenzileMele => _driver.FindElement(By.CssSelector("body > div.wrapper > div > div.main-container.col2-left-layout > div > div.row > div.col-left.sidebar.col-xs-12.col-md-3 > div > div > ul > li:nth-child(4) > a"));
        private IWebElement NoOrders => _driver.FindElement(By.CssSelector("p.orders-empty"));
        private IWebElement PaginaPrincipala => _driver.FindElement(By.CssSelector("/html/body/div[1]/div/div[1]/div/div[1]/ul/li[1]/a"));
        public IWebElement Deconectare => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-left.col-xs-12.col-md-4.mobile-search-wrap > ul > li:nth-child(3) > a"));

    }
}
