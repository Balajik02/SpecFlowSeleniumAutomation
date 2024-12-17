using Automation.PageObjects.AutomationTesting;
using AutomationCore.Config;
using BoDi;
using TechTalk.SpecFlow;

namespace Automation.Tests.Steps
{
    [Binding]
    public class AutomationTestSiteSteps : BaseSteps
    {
        readonly HomePage homePage;
        public AutomationTestSiteSteps(ObjectContainer container, ScenarioContext scenarioContext) : base(container, scenarioContext)
        {
            homePage = new HomePage(driver);
        }

        [Given(@"I navigate to the registration page")]
        public void NavigateToDemoSite()
        {
            string baseUrl = ConfigReader.GetAppSetting("BaseUrl");
            homePage.NavigateToPage(baseUrl);
            homePage.NavLinkElement("Demo Site");
        }
    }
}