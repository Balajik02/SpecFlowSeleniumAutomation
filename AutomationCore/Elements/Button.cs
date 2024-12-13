using OpenQA.Selenium;
using System;

namespace AutomationCore.Elements
{
    public class Button : BaseControl
    {
        public Button(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        public void ClickButton(IWebDriver driver, By locator)
        {
            try
            {
                Element.Click();
                Console.WriteLine("Button clicked successfully.");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Error: Button not found - {ex.Message}");
                throw;
            }
        }

        // Method to Check if Button is Enabled
        public bool IsButtonEnabled(IWebDriver driver, By locator)
        {
            try
            {
                return Element.Enabled;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Error: Button not found - {ex.Message}");
                return false;
            }
        }

        // Method to Wait and Click a Button
        public void WaitAndClickButton(IWebDriver driver, By locator, TimeSpan timeout)
        {
            try
            {
                WaitForElementClickable();
                Element.Click();
                Console.WriteLine("Button clicked after waiting successfully.");
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"Error: Button not clickable within timeout - {ex.Message}");
                throw;
            }
        }

        // Method to Get Button Text
        public string GetButtonText(IWebDriver driver, By locator)
        {
            try
            {
                return Element.Text;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Error: Button not found - {ex.Message}");
                throw;
            }
        }

        // Method to Verify Button Visibility
        public bool IsButtonVisible(IWebDriver driver, By locator)
        {
            try
            {
                return Element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
