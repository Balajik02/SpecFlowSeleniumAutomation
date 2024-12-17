using OpenQA.Selenium;

namespace AutomationCore.Elements
{
    public class Checkbox : BaseControl
    {
        public Checkbox(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        /// <summary>
        /// Checks the checkbox if it is not already checked.
        /// </summary>
        public void Check()
        {
            if (!IsChecked())
            {
                WaitForElementClickable();
                Element.Click();
            }
        }

        /// <summary>
        /// Unchecks the checkbox if it is not already unchecked.
        /// </summary>
        public void Uncheck()
        {
            if (IsChecked())
            {
                WaitForElementClickable();
                Element.Click();
            }
        }

        /// <summary>
        /// Checks if the checkbox is currently checked.
        /// </summary>
        /// <returns>true if the checkbox is checked, otherwise false.</returns>
        public bool IsChecked()
        {
            return Element.Selected;
        }
    }
}