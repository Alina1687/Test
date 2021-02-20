using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test2.PageObjects
{
    partial class ProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        //public ProductPage(IWebDriver driver)
        //{
        //    _driver = driver;
        //    _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        //}
        public ProductPage(IWebDriver driver) => _driver = driver;


        private IWebElement AdaugaInCosButton => _driver.FindElement(By.XPath("//button[@id='product-addtocart-button']"));
        private IWebElement AdaugaLaFavorite=> _driver.FindElement(By.CssSelector("//a.wishlist-add.waves-effect.waves-light"));
        private IWebElement VeziToate => _driver.FindElement(By.XPath("//*[@id='narrow - by - list']/dd[3]/ol/li[8]/a"));
    }
}

