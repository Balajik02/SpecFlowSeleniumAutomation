using AutomationCore.Elements;
using OpenQA.Selenium;
using System;

namespace AutomationCore.DriverService
{
    public class BasePage
    {
        readonly IWebDriver _webdriver;
        public BasePage(IWebDriver webdriver) 
        {
            _webdriver = webdriver ?? throw new ArgumentNullException(nameof(webdriver));
        }

        public void NavigateToPage(string url)
        {
            _webdriver.Navigate().GoToUrl(url);
        }
    }
}
