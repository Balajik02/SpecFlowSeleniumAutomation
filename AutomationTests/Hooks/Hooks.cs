using AutomationCore.Config;
using AutomationCore.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Automation.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IWebDriver _driver;

        public Hooks(IWebDriver driver)
        {
            _driver = driver;
        }

        string browser = ConfigReader.GetAppSetting("Browser");

        // Initialize the WebDriver before each scenario using DriverStartup
        [BeforeScenario]
        public void InitializeDriver()
        {
            // Choose the driver type (Chrome, Edge, Firefox)
            //DriverType driverType = DriverType.Chrome;  // You can change this as needed

            // Get the driver instance from DriverStartup
            //_driver = DriverStartup.CreateDriver(driverType);

            DriverFactory.GetDriver(browser);
        }

        // Clean up the WebDriver after each scenario
        [AfterScenario]
        public void CleanupDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}
