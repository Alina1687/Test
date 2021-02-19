using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    partial class HomePage
    {
      

        public void GoToAuthentication()
        {
           AutentificareInregistrare.Click();
        }

        public void GoToCart()
        {
            Cos.Click();
        }
        public void GoToMenu()
        {
            MenuManager.Click();
        }
        public IWebElement GetMenuElement(string menuName)
        {
            return MenuManager.FindElement(By.XPath($"//a[contains(text(),'{menuName}')]"));
        }
        public void GoToReteaMagazine()
        {
            ReteaMagazine.Click();
        }
        //    public void ClickEveryMenu()
        //    {
        //        Click();
        //        .Click();
        //        .Click();
        //        .Click();
        //        .Click();

        public void GoToBestseller()
        {
            Bestseller.Click();
        }
        public void GoToInfoInEnglish()
        {
            GoToInformationInEnglish.Click();
        }
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);

        }
        public void HomeNobilaCasa()
        {
            NobilaCasaHome.Click();
        }
        public void GoToBlogPage()
        {
            Blog.Click();
        }
        public void Search(string element)
        {
            SearchButton.SendKeys(element);
            SearchButton.Submit();
        }
        //    }
    }
}
