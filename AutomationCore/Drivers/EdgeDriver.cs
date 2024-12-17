using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace AutomationCore.Drivers
{
    public class EdgeDriver : BaseWebDriver
    {
        public override IWebDriver CreateDriver()
        {
            // You can configure Edge options here if needed
            var options = SetEdgeOptions();
            var service = SetEdgeService();

            Driver = new OpenQA.Selenium.Edge.EdgeDriver(service,options);
            return Driver;
        }

        private EdgeOptions SetEdgeOptions()
        {
            var edgeOptions = new EdgeOptions();
           
            // Add basic options
            edgeOptions.AddArgument("--start-maximized");  // Start browser maximized
            edgeOptions.AddArgument("--disable-extensions"); // Disable extensions options.AddArgument("--disable-extensions"); // Disable extensions
            edgeOptions.AddArgument("--disable-infobars"); // Disable infobars
            edgeOptions.AddArgument("--incognito");
            edgeOptions.AddArgument("--inprivate");
            edgeOptions.AddAdditionalOption("useAutomationExtension", false); // Disable automation extension
            //options.AddArgument("--headless"); // Run in headless mode

            return edgeOptions;

        }

        private EdgeDriverService SetEdgeService()
        {
            var service = EdgeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true; // Suppress the command prompt

            return service;
        }
    }
}
