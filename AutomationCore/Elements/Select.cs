using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace AutomationCore.Elements
{
    public class Select : BaseControl
    {
        public Select(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        /// <summary>
        /// Selects an option by visible text.
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <param name="text">Visible text to select</param>
        public void SelectByText(string text)
        {
            var dropdown = new SelectElement(Element);
            dropdown.SelectByText(text);
        }

        /// <summary>
        /// Selects an option by value.
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <param name="value">Value attribute of the option to select</param>
        public void SelectByValue(string value)
        {
            var dropdown = new SelectElement(Element);
            dropdown.SelectByValue(value);
        }

        /// <summary>
        /// Selects an option by index.
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <param name="index">Index of the option to select</param>
        public void SelectByIndex(int index)
        {
            var dropdown = new SelectElement(Element);
            dropdown.SelectByIndex(index);
        }

        /// <summary>
        /// Gets the selected option's text.
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <returns>Text of the selected option</returns>
        public string GetSelectedOption(By locator)
        {
            var dropdown = new SelectElement(Element);
            return dropdown.SelectedOption.Text;
        }

        /// <summary>
        /// Gets all options from the dropdown.
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <returns>List of all options as strings</returns>
        public IList<string> GetAllOptions(By locator)
        {
            var dropdown = new SelectElement(Element);
            return dropdown.Options.Select(option => option.Text).ToList();
        }

        /// <summary>
        /// Checks if the dropdown is multi-select.
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <returns>True if multi-select, otherwise false</returns>
        public bool IsMultiSelect(By locator)
        {
            var dropdown = new SelectElement(Element);
            return dropdown.IsMultiple;
        }

        /// <summary>
        /// Deselects all selected options (only for multi-select dropdowns).
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        public void DeselectAll(By locator)
        {
            var dropdown = new SelectElement(Element);
            dropdown.DeselectAll();
        }

        /// <summary>
        /// Deselects an option by visible text (only for multi-select dropdowns).
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <param name="text">Visible text of the option to deselect</param>
        public void DeselectByText(string text)
        {
            var dropdown = new SelectElement(Element);
            dropdown.DeselectByText(text);
        }

        /// <summary>
        /// Deselects an option by value (only for multi-select dropdowns).
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <param name="value">Value attribute of the option to deselect</param>
        public void DeselectByValue(string value)
        {
            var dropdown = new SelectElement(Element);
            dropdown.DeselectByValue(value);
        }

        /// <summary>
        /// Deselects an option by index (only for multi-select dropdowns).
        /// </summary>
        /// <param name="locator">Locator of the dropdown</param>
        /// <param name="index">Index of the option to deselect</param>
        public void DeselectByIndex(int index)
        {
            var dropdown = new SelectElement(Element);
            dropdown.DeselectByIndex(index);
        }
    }
}