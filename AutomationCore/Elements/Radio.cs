using OpenQA.Selenium;

namespace AutomationCore.Elements
{
    internal class Radio : BaseControl
    {
        public Radio(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        // Method to select the radio button
        public void Select()
        {
            // Check if the radio button is not selected and select it
            if (!Element.Selected)
            {
                Element.Click();
            }
        }

        // Method to verify if the radio button is selected
        public bool IsSelected()
        {
            return Element.Selected;
        }

        // Method to get the label text for the radio button (if needed)
        public string GetLabelText()
        {
            return Element.GetDomAttribute("value");
        }
    }
}