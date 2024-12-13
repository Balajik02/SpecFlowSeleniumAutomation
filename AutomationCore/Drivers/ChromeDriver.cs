using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationCore.Drivers
{
    public class ChromeDriver : BaseWebDriver
    {
        public override IWebDriver CreateDriver()
        {
            // You can configure Chrome options here if needed
            var options = new ChromeOptions();
            // Example: options.AddArgument("--headless");

            Driver = new OpenQA.Selenium.Chrome.ChromeDriver(options);
            return Driver;
        }
    }
}
