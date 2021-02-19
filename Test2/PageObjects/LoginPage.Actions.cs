using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    partial class LoginPage
    {

        public void AuthenticateUser(UserDto user)
        {
            EmailFieldText.SendKeys(user.UserEmail);
            PasswordFieldtext.SendKeys(user.UserPassword);
            AutentificareButton.Click();

        }
        public void DisconectUser()
        {

            Deconectare.Click();


        }

        public void GoToFavoriteList()
        {
            
            ListaFavorite.Click();

        
        }

        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);

        }
        public void VerifyErrorMessageAuthentification(string expectedMessage)
        {

            Assert.IsTrue(ErrorMessageAuthentification.Displayed);
        }

        public void GoToAccount()
        {
            ContulMeuButton.Click();
        }
        public void GoToMainPage()
        {
            GoToPaginaPrincipala.Click();
        }
    }
}
