using OpenQA.Selenium;

namespace AutomationCore.Drivers
{
    public abstract class BaseWebDriver : IDriver
    {
        public IWebDriver Driver { get; set; }

        // Abstract method to be implemented by the derived classes
        public abstract IWebDriver CreateDriver();

        // Common method to quit the driver
        public void Quit()
        {
            Driver?.Quit();
        }

        // Navigate to a given URL
        public void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
