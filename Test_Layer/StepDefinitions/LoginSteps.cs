using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using PageObjects;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage_Actions loginPageActions;

        public LoginSteps()
        {
            loginPageActions = new LoginPage_Actions();
        }

        [Given("I navigate to the login page URL '(.*)'")]
        public void GivenINavigateToTheLoginPageURL(string url)
        {
            loginPageActions.NavigateToUrl(url);
        }

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            loginPageActions.EnterCredentials(username, password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPageActions.ClickLoginButton();
        }

        [Then("I should see the product page")]
        public void ThenIShouldSeeTheProductPage()
        {
            Assert.IsTrue(loginPageActions.IsProductPageVisible(), "Product page is not visible after login.");
        }

        [Then("I should see an error message '(.*)'")]
        public void ThenIShouldSeeAnErrorMessage(string errorMessage)
        {
            Assert.AreEqual(errorMessage, loginPageActions.GetErrorMessage(), "Error message does not match.");
        }
    }
}