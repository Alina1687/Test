using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();

        }
        public IWebElement AutentificareInregistrare => _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-left.col-xs-12.col-md-4.mobile-search-wrap > ul > li:nth-child(3) > a")));
        //public IWebElement AutentificareInregistrare => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-left.col-xs-12.col-md-4.mobile-search-wrap > ul > li:nth-child(3) > a"));

        private IWebElement ContulMeu => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-mobile.mobile-nav-btns-wrap > div > div.mobile-nav-btn-wrap.btn-account"));

        private IWebElement Cos => _driver.FindElement(By.CssSelector("//a[@title='Coșul meu']"));
        private IWebElement MenuManager => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.header-menu > ul"));
        public IWebElement CategoryLabel => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.header-menu > ul"));

        public IWebElement ReteaMagazine => _driver.FindElement(By.XPath("//a[@title='rețea magazine']"));
        public IWebElement ArataHarta => _driver.FindElement(By.XPath("//*[@id='shop_9']/div[3]"));
        private IWebElement NobilaCasaHome => _driver.FindElement(By.CssSelector("//a[@title='NobilaCasa']"));
        private IWebElement GoToInformationInEnglish => _driver.FindElement(By.CssSelector("//a[@title='Information in English']"));

        private IWebElement Bestseller => _driver.FindElement(By.CssSelector("//h3[text()='Bestsellers']"));
        private IWebElement SearchButton => _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("q")));
        public IWebElement ImageFrame => _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("body > div.wrapper > div > div.main-container.col2-left-layout > div > div.row > div.col-main.col-xs-12.col-md-9 > div > ul > li > div > div.product-name > a")));
        private IWebElement Blog => _driver.FindElement(By.XPath("/html/body/div[1]/div/header/div/div[2]/ul/li[8]/a/span"));
    }
}
