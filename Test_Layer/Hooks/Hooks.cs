using TechTalk.SpecFlow;
using Utilities.WebUtilities;

namespace Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private WebUtilities webUtilities;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities = new WebUtilities();
            webUtilities.InitializeDriver("chrome");
            _scenarioContext["WebUtilities"] = webUtilities;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}