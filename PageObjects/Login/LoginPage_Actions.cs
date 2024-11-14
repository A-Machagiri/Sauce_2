using Utilities.WebUtilities;
using OpenQA.Selenium;

namespace PageObjects.Login
{
    public class LoginPage_Actions
    {
        private WebUtilities _webUtilities;

        public LoginPage_Actions(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password)
        {
            _webUtilities.SendKeys(LoginPage_Locators.UsernameField, username);
            _webUtilities.SendKeys(LoginPage_Locators.PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginPage_Locators.LoginButton);
        }

        public bool IsErrorMessageVisible()
        {
            return _webUtilities.FindElement(LoginPage_Locators.ErrorMessage).Displayed;
        }

        public bool IsProductPageVisible()
        {
            return _webUtilities.FindElement(LoginPage_Locators.ProductLabel).Displayed;
        }
    }
}