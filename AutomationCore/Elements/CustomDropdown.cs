using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomationCore.Elements
{
    internal class CustomDropdown : BaseControl
    {
        public CustomDropdown(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        /// <summary>
        /// Selects an option from the dropdown by its visible text.
        /// </summary>
        /// <param name="text">The visible text of the option to select.</param>
        public void SelectByText(string text)
        {
            if (string.IsNullOrEmpty(text)) throw new ArgumentException("Text cannot be null or empty", nameof(text));

            var options = GetAllOptionElements();
            var optionToSelect = options.FirstOrDefault(opt => opt.Text.Equals(text, StringComparison.OrdinalIgnoreCase));

            if (optionToSelect == null)
                throw new NoSuchElementException($"Option with text '{text}' not found.");

            optionToSelect.Click();
        }

        /// <summary>
        /// Selects an option from the dropdown by its value attribute.
        /// </summary>
        /// <param name="value">The value of the option to select.</param>
        public void SelectByValue(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Value cannot be null or empty", nameof(value));

            var options = GetAllOptionElements();
            var optionToSelect = options.FirstOrDefault(opt => opt.GetDomAttribute("value") == value);

            if (optionToSelect == null)
                throw new NoSuchElementException($"Option with value '{value}' not found.");

            optionToSelect.Click();
        }

        /// <summary>
        /// Retrieves all available options in the dropdown as a list of strings.
        /// </summary>
        /// <returns>A list of strings representing the visible text of all options.</returns>
        public List<string> GetAllOptions()
        {
            return GetAllOptionElements().Select(opt => opt.Text).ToList();
        }

        /// <summary>
        /// Retrieves all available option elements in the dropdown.
        /// </summary>
        /// <returns>A list of IWebElement representing all options.</returns>
        private IReadOnlyCollection<IWebElement> GetAllOptionElements()
        {
            //wait.Until(driver => Element.Displayed);
            WaitForElementVisible();
            return Element.FindElements(By.TagName("option"));
        }
    }
}
