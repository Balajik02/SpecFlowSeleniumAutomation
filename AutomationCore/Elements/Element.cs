using OpenQA.Selenium;

namespace AutomationCore.Elements
{
    public class Element : BaseControl
    {
        public Element(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        public void ClickUsingJavaScript()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", Element);
        }
    }
}
