using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage_Actions _loginPageActions;

        public LoginSteps()
        {
            _loginPageActions = new LoginPage_Actions();
        }

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _loginPageActions.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPageActions.EnterCredentials("standard_user", "secret_sauce");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            _loginPageActions.EnterCredentials("invalid_user", "invalid_sauce");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPageActions.ClickLoginButton();
        }

        [Then("I should see the products page")]
        public void ThenIShouldSeeTheProductsPage()
        {
            Assert.IsTrue(_loginPageActions.IsProductsPageVisible(), "Products page is not visible after login.");
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_loginPageActions.IsErrorMessageVisible(), "Error message is not visible after failed login.");
        }
    }
}