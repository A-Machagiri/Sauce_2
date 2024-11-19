using TechTalk.SpecFlow;
using PageObjects.Login;
using NUnit.Framework;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage;
        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            loginPage = new LoginPage((WebUtilities)_scenarioContext["WebUtilities"]);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPage.NavigateToUrl("https://www.saucedemo.com/");
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            loginPage.EnterCredentials(username, password);
            loginPage.ClickLoginButton();
        }

        [Then("I should be logged in and redirected to the products page")]
        public void ThenIShouldBeLoggedInAndRedirectedToTheProductsPage()
        {
            Assert.IsTrue(loginPage.IsOnProductsPage());
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        [When("I enter invalid username '(.*)' and valid password '(.*)'")]
        [When("I leave the username field empty and enter password '(.*)'")]
        [When("I enter username '(.*)' and leave the password field empty")]
        public void WhenIEnterCredentials(string username, string password)
        {
            loginPage.EnterCredentials(username, password);
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        [Then("an error message should be displayed indicating (.*)")]
        public void ThenCheckResult(string message)
        {
            if (message.Contains("redirected to the products page"))
                Assert.IsTrue(loginPage.IsOnProductsPage());
            else
                Assert.AreEqual(message, loginPage.GetErrorMessage());
        }
    }
}