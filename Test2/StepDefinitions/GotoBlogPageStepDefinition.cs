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
    public sealed class GotoBlogPageStepDefinition:Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        //private readonly ScenarioContext _scenarioContext;

        //public GotoBlogPageStepDefinition(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        [Given(@"I am on the site")]
        public void GivenIAmOnTheSite()
        {

            HomePage homePage = new HomePage(Driver);
            homePage.AutentificareInregistrare.Click();
            LoginPage loginPage = new LoginPage(Driver);

            

        }

        [When(@"I press the Blog button")]
        public void WhenIPressTheBlogButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToBlogPage();

        }

        [Then(@"I am sent to Blog page")]
        public void ThenIAmSentToBlogPage()
        {
            BlogPage blogPage = new BlogPage(Driver);
            Assert.IsTrue(blogPage.AboutUS.Displayed);
        }
    }
}
