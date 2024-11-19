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

        [When("I enter invalid username '(.*)' and valid password '(.*)'")]
        public void WhenIEnterInvalidUsernameAndValidPassword(string username, string password)
        {
            loginPage.EnterCredentials(username, password);
            loginPage.ClickLoginButton();
        }

        [Then("I should see an error message indicating invalid username")]
        public void ThenIShouldSeeAnErrorMessageIndicatingInvalidUsername()
        {
            Assert.AreEqual("Error: Username and password do not match any user in this service", loginPage.GetErrorMessage());
        }

        // Additional steps for other scenarios can be added here
    }
}