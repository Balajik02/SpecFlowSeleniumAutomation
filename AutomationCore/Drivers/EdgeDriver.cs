using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace AutomationCore.Drivers
{
    public class EdgeDriver : BaseWebDriver
    {
        public override IWebDriver CreateDriver()
        {
            // You can configure Edge options here if needed
            var options = new EdgeOptions();
            // Example: options.AddArgument("--headless");

            Driver = new OpenQA.Selenium.Edge.EdgeDriver(options);
            return Driver;
        }
    }
}
