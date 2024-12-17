using OpenQA.Selenium;
using System;

namespace AutomationCore.Elements
{
    public class Button : BaseControl
    {
        public Button(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        public void ClickButton()
        {
            try
            {
                Element.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Error: Button not found - {ex.Message}");
                throw;
            }
        }

        // Method to Check if Button is Enabled
        public bool IsButtonEnabled()
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
        public void WaitAndClickButton()
        {
            try
            {
                WaitForElementClickable();
                Element.Click();
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"Error: Button not clickable within timeout - {ex.Message}");
                throw;
            }
        }

        // Method to Get Button Text
        public string GetButtonText()
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
        public bool IsButtonVisible()
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