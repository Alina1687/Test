using NUnit.Framework;
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
    public sealed class InvalidLoginStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public InvalidLoginStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I navigate to my authentication page")]
        public void GivenINavigateToMyAuthenticationPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
        }

        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser(user);
        }
        [Then(@"error message appear")]
        public void ThenErrorMessageAppear()
        {
            LoginPage loginPage = new LoginPage(Driver);
            Assert.IsTrue(loginPage.ErrorMessageAuthentification.Displayed);
        }

    }
}