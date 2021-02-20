using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Test2.PageObjects;

namespace Test2.StepDefinitions
{
    [Binding]
    public sealed class GotoBlogPageStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        //private readonly ScenarioContext _scenarioContext;

        //public GotoBlogPageStepDefinition(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}
        public IWebDriver _driver;
        public GotoBlogPageStepDefinition(IWebDriver driver) => _driver = driver;

        [Given(@"I am on the site")]
        public void GivenIAmOnTheSite()
        {
            BasePage basePage = new BasePage(_driver);
            basePage.NavigateToUrl(basePage.NobilaUrl);
            HomePage homePage = new HomePage(_driver);
           homePage.GoToAuthentication();

        }

        [When(@"I press the Blog button")]
        public void WhenIPressTheBlogButton()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.GoToBlogPage();

        }

        [Then(@"I am sent to Blog page")]
        public void ThenIAmSentToBlogPage()
        {
            BlogPage blogPage = new BlogPage(_driver);
            Assert.IsTrue(blogPage.AboutUS.Displayed);
        }
    }
}
