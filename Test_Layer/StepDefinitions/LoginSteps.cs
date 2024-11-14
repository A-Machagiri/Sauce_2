using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Test_Layer.StepDefinitions
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
            _loginPageActions.EnterCredentials("invalid_user", "wrong_password");
        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            Assert.IsTrue(_loginPageActions.IsLoggedInSuccessfully(), "Login was not successful.");
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_loginPageActions.IsErrorMessageDisplayed(), "Error message was not displayed.");
        }
    }
}