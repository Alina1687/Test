using NUnit.Framework;
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
        public void EditOption()
        {
            Modifica.Click();
        }
        public void GoToDateleMele()
        {
            DateleMele.Click();
        }
        public void GoToUserPhoto()
        {
            PozaProfil.Click();
        }
        public void ViewMyOrders()
        {
            ComenzileMele.Click();
        }
        public void GoToMainPage()
        {
            PaginaPrincipala.Click();
        }
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);

        }

    }
}
