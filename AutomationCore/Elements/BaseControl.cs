using AutomationCore.Waiters;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationCore.Elements
{
    public class BaseControl
    {
        protected IWebDriver _driver;
        protected By _locator;
        protected Lazy<IWebElement> _LazyElement;

        public BaseControl(IWebDriver driver, By locator)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            _locator = locator;
            _LazyElement = new Lazy<IWebElement>(()=>_driver.FindElement(_locator));
        }

        protected IWebElement Element => _LazyElement.Value;

        protected void WaitForElementVisible(int timeout=10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(_locator));
        }

        protected void WaitForElementClickable(int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementToBeClickable(_locator));
        }
    }
}