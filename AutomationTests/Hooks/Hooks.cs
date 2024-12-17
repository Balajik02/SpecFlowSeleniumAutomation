using AutomationCore.Config;
using AutomationCore.Drivers;
using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Automation.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
     //   private IReport _report;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        string browser = ConfigReader.GetAppSetting("Browser");
    //    string report = ConfigReader.GetAppSetting("ReportType");

        // Initialize the WebDriver before each scenario using DriverStartup
        [BeforeScenario]
        public void InitializeDriver()
        {
            var driver = DriverFactory.GetDriver(browser);
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            
         //   _report = ReportFactory.CreateReport(report);
           // _report.IntializeReport();
        }

        // Clean up the WebDriver after each scenario
        [AfterScenario]
        public void CleanupDriver()
        {
            var driver = _objectContainer.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }
         //   _report.GenerateReport();
        }
    }
}