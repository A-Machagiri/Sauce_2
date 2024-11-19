// LoginPage_Locators.cs
namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public static By UsernameField = By.Id("user-name");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login-button");
        public static By ErrorMessage = By.CssSelector(".error-message-container");
        public static By ProductsPageTitle = By.ClassName("product_label");
    }
}