using NUnit.Framework;
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
    public sealed class FavoritesListStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        //private readonly ScenarioContext _scenarioContext;

        //public FavoritesListStep(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}
        public IWebDriver _driver;
        public FavoritesListStep(IWebDriver driver) => _driver = driver;

        //  public IWebDriver Driver { get; private set; }

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
            Assert.IsTrue(loginPage.Deconectare.Displayed);
        }

        [Then(@"I can go to FavoriteList")]
        public void ThenICanGoToFavoriteList()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.GoToFavoriteList();
            Assert.IsTrue(loginPage.FavoriteView.Displayed);
        }

        


    }
}
