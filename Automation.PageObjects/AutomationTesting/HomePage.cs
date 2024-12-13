using OpenQA.Selenium;
using AutomationCore.Elements;
using AutomationCore.DriverService;

namespace Automation.PageObjects.AutomationTesting
{
    public class HomePage : BasePage
    {
        public readonly IWebDriver _driver;

        // Constructor to inject the WebDriver instance
        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        By navLinks = By.XPath("//nav[@id='main-nav-wrap']/ul/li/a");

        public void NavLinkElement(string linkName)
        {
            Link link = new Link(_driver, navLinks);
            link.ClickLinkByText(linkName);
        }
    }
}
