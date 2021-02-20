using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        //public LoginPage(IWebDriver driver)
        //{
        //    _driver = driver;
        //    _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        //}
        public LoginPage(IWebDriver driver) => _driver = driver;



        public IWebElement EmailFieldText => _driver.FindElement(By.XPath("//input[@class='input-text required-entry validate-email']"));
        public IWebElement PasswordFieldtext => _driver.FindElement(By.XPath("//input[@class='input-text required-entry validate-password']"));
        // public IWebElement AutentificareButton => _driver.FindElement(By.XPath("//button[@name='send' ]"));
        public IWebElement AutentificareButton => _driver.FindElement(By.CssSelector(".registered-users"));
        public IWebElement Deconectare => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-left.col-xs-12.col-md-4.mobile-search-wrap > ul > li:nth-child(3) > a"));
        private IWebElement ListaFavorite => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-left.col-xs-12.col-md-4.mobile-search-wrap > ul > li:nth-child(2) > a"));
        // private IWebElement ErrorMessageAuthentification => _driver.FindElement(By.XPath(""));
        public IWebElement FavoriteView => _driver.FindElement(By.XPath("body > div.wrapper > div > div.main-container.col2-left-layout > div > div.row > div.col-main.col-xs-12.col-md-9 > div > div > div.section-title"));
        public IWebElement GoToPaginaPrincipala => _driver.FindElement(By.CssSelector("//a[text()='Pagina Principală']"));
        public IWebElement ContulMeuButton => _driver.FindElement(By.CssSelector("body > div.wrapper > div > header > div > div.row > div.section-mobile.mobile-nav-btns-wrap > div > div.mobile-nav-btn-wrap.btn-account"));

      //  private IWebElement AutentificareButton => _driver.FindElement(By.XPath("//*[@id='send2']"));
       public IWebElement ErrorMessageAuthentification => _driver.FindElement(By.XPath("//div[@id='advice-validate-password-pass']"));
    }
}