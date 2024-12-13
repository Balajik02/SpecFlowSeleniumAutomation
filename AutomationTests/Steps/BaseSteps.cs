using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Automation.Tests.Steps
{
    public class BaseSteps
    {
        public readonly IObjectContainer _container;
        public readonly ScenarioContext _scenarioContext;
        public readonly FeatureContext _featureContext;
        public IWebDriver driver;

        protected BaseSteps(IObjectContainer container, ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _container = container;
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }

        protected BaseSteps(IObjectContainer container, ScenarioContext scenarioContext)
        {
            _container = container;
            _scenarioContext = scenarioContext;
            driver = container.Resolve<IWebDriver>(); 
        }
    }
}
