using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationCore.Waiters
{
    public static class Waiter
    {
        static TimeSpan timeout = TimeSpan.FromSeconds(20);
        // Static method to wait for an element to be present
        public static IWebElement WaitForElementToBePresent(IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        // Static method to wait for an element to be visible
        public static IWebElement WaitForElementToBeVisible(IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        // Static method to wait for an element to be clickable
        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        // Static method to wait for an element's text to match a specific value
        public static IWebElement WaitForElementTextToBe(IWebDriver driver, By locator, string text)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(d =>
            {
                var element = d.FindElement(locator);
                return element.Text == text ? element : null;
            });
        }

        // Static method to wait for an alert to be present
        public static IAlert WaitForAlert(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        }

        // Static method to wait for a specific condition to be true (using a lambda expression)
        public static T WaitForCondition<T>(IWebDriver driver, Func<IWebDriver, T> condition)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(condition);
        }
    }
}