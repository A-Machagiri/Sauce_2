using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

[Binding]
public class LoginSteps
{
    private LoginPage_Actions _loginPageActions;

    public LoginSteps(WebUtilities webUtilities)
    {
        _loginPageActions = new LoginPage_Actions(webUtilities);
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        // Implementation to navigate to login page
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

    [Then("I should be redirected to the product page")]
    public void ThenIShouldBeRedirectedToTheProductPage()
    {
        var title = _loginPageActions.GetProductPageTitle();
        Assert.AreEqual("Products", title);
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        var errorMessage = _loginPageActions.GetErrorMessage();
        Assert.IsTrue(errorMessage.Contains("error"));
    }
}