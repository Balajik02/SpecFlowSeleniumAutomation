
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace AutomationCore.Drivers
{
    public class ChromeDriver : BaseWebDriver
    {
        public override IWebDriver CreateDriver()
        {
            var options = SetChromeOptions();
            var service = SetChromeDriverService();

            Driver = new OpenQA.Selenium.Chrome.ChromeDriver(service,options);
            return Driver;
        }

        private ChromeOptions SetChromeOptions()
        {
            var options = new ChromeOptions();
            // Add basic options
            options.AddArgument("--incognito");
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-gpu"); // Disable GPU
            //options.AddArgument("--window-size=1920,1080"); // Set window size
            options.AddArgument("--disable-extensions"); // Disable extensions
            options.AddArgument("--disable-infobars"); // Disable info bars
            options.AddArgument("--no-sandbox"); // Disable sandboxing
            options.AddExcludedArgument("enable-automation"); // Remove automation flag
            options.AddAdditionalOption("useAutomationExtension", false); // Disable automation extension
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--log-level=3"); // Suppress most logs

            //options.AddArgument("--headless"); // Run in headless mode

            // Add experimental options
            var prefs = new Dictionary<string, object>
            { 
                { "profile.default_content_setting_values.notifications", 2 }, // Block notifications
                { "profile.managed_default_content_settings.cookies", 1 } // Enable cookies
            };
            options.AddUserProfilePreference("prefs", prefs);

            return options;
        }

        private ChromeDriverService SetChromeDriverService()
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true; // Hides the command prompt window
            service.SuppressInitialDiagnosticInformation = true; // Suppress diagnostic info
            service.EnableVerboseLogging = false; // Disable verbose logging
            return service;
        }
    }
}
