using TechTalk.SpecFlow;
using Utilities.WebUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[Binding]
public class Hooks
{
    private IWebDriver _driver;
    private WebUtilities _webUtilities;

    [BeforeScenario]
    public void BeforeScenario()
    {
        _driver = new ChromeDriver();
        _webUtilities = new WebUtilities(_driver);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _driver.Quit();
    }
}