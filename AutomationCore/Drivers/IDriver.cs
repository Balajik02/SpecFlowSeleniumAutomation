using OpenQA.Selenium;

namespace AutomationCore.Drivers
{
    public interface IDriver
    {
        public IWebDriver CreateDriver();
        public void Quit();
        public void NavigateTo(string url);
        public IWebDriver Driver { get; }
    }
}
