using TechTalk.SpecFlow;
using PageObjects.Login;

[Binding]
public class LoginSteps
{
    private LoginPage_Actions _loginPageActions;

    public LoginSteps(LoginPage_Actions loginPageActions)
    {
        _loginPageActions = loginPageActions;
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
        _loginPageActions.EnterCredentials("locked_out_user", "secret_sauce");
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPageActions.ClickLoginButton();
    }

    [Then("I should be redirected to the product page")]
    public void ThenIShouldBeRedirectedToTheProductPage()
    {
        Assert.IsTrue(_loginPageActions.IsProductPageVisible());
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(_loginPageActions.IsErrorMessageVisible());
    }
}