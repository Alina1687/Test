using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Test2.PageObjects;

namespace Test2.StepDefinitions
{
    [Binding]
    public sealed class AuthenticationStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        //   private readonly ScenarioContext _scenarioContext;
        //public IWebDriver Driver { get; private set; }
        public IWebDriver _driver;
        public AuthenticationStepDefinition(IWebDriver driver) => _driver = driver;
       
        //public AuthenticationStepDefinition(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        //[Given(@"I navigate to authentication page")]
        //public void GivenINavigateToAuthenticationPage()
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.GoToAuthentication();
        //}

        //[When(@"I login with user '(.*)'")]
        //public void WhenILoginWithUser(string UserEmail)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    //  loginPage.AuthenticateUser("alytestare@gmail.com", "Test12345");

        //    loginPage.EmailFieldText.SendKeys(UserEmail);
        //}

        //[When(@"password '(.*)'")]
        //public void WhenPassword(string UserPassword)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.PasswordFieldtext.SendKeys(UserPassword);
        //    loginPage.AutentificareButton.Click();
        //}

        //[Then(@"I am logged in")]
        //public void ThenIAmLoggedIn()
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    Assert.IsTrue(loginPage.Deconectare.Displayed);

        //}
        [Given(@"I navigate to my authentication page")]
        public void GivenINavigateToMyAuthenticationPage()
        {
        BasePage basePage = new BasePage(_driver);
        basePage.NavigateToUrl(basePage.NobilaUrl);
         HomePage homePage = new HomePage(_driver);
        homePage.GoToAuthentication();

        }

        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.AuthenticateUser(user);
        }

        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            LoginPage loginPage = new LoginPage(_driver);
            Assert.IsTrue(loginPage.Deconectare.Displayed);
        }


    }
}

