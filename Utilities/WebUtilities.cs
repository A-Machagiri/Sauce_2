using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace Utilities.WebUtilities
{
    public class WebUtilities
    {
        private IWebDriver driver;

        public void InitializeDriver(string browserType)
        {
            switch (browserType.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser not supported");
            }
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }

        public void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public void SendKeys(By locator, string text)
        {
            FindElement(locator).SendKeys(text);
        }

        public void Quit()
        {
            driver.Quit();
        }
    }
}