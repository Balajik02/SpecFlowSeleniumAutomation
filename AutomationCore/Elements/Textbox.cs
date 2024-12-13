using OpenQA.Selenium;
using System;

namespace AutomationCore.Elements
{
    internal class TextBox : BaseControl
    {
        public TextBox(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        /// <summary>
        /// Enters text into a textbox.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        /// <param name="text">Text to be entered</param>
        public void EnterText(string text)
        {
            Element.Clear();
            Element.SendKeys(text);
        }

        /// <summary>
        /// Clears the text from a textbox.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        public void ClearText(By locator)
        {
            Element.Clear();
        }

        /// <summary>
        /// Gets the text from a textbox.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        /// <returns>Text present in the textbox</returns>
        public string GetText(By locator)
        {
            return Element.Text ?? Element.GetDomAttribute("value");
        }

        /// <summary>
        /// Checks if the textbox is displayed.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        /// <returns>True if displayed, otherwise false</returns>
        public bool IsDisplayed(By locator)
        {
            return Element.Displayed;
        }

        /// <summary>
        /// Checks if the textbox is enabled.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        /// <returns>True if enabled, otherwise false</returns>
        public bool IsEnabled(By locator)
        {
            return Element.Enabled;
        }


        /// <summary>
        /// Appends text to the existing text in the textbox.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        /// <param name="text">Text to append</param>
        public void AppendText(By locator, string text)
        {
            Element.SendKeys(text);
        }

        /// <summary>
        /// Checks if the textbox is read-only.
        /// </summary>
        /// <param name="locator">Locator of the textbox</param>
        /// <returns>True if read-only, otherwise false</returns>
        public bool IsReadOnly(By locator)
        {
            string readOnly = Element.GetDomProperty("readonly");
            return readOnly != null && readOnly.Equals("true", StringComparison.OrdinalIgnoreCase);
        }
    }
}