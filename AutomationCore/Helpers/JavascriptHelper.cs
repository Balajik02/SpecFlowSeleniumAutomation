using OpenQA.Selenium;
using System;

namespace AutomationCore.Helpers
{
    internal class JavascriptHelper
    {
        public static class JavaScriptHelper
        {
            /// <summary>
            /// Executes a JavaScript script on the current browser.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="script">The JavaScript code to execute.</param>
            /// <param name="args">Optional arguments for the script.</param>
            /// <returns>The result of the script execution, if any.</returns>
            public static object ExecuteScript(IWebDriver driver, string script, params object[] args)
            {
                if (driver is IJavaScriptExecutor jsExecutor)
                {
                    return jsExecutor.ExecuteScript(script, args);
                }

                throw new NotSupportedException("The WebDriver does not support JavaScript execution.");
            }

            /// <summary>
            /// Scrolls the page to the specified element.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The element to scroll to.</param>
            public static void ScrollToElement(IWebDriver driver, IWebElement element)
            {
                ExecuteScript(driver, "arguments[0].scrollIntoView(true);", element);
            }

            /// <summary>
            /// Highlights the specified element by changing its background color.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The element to highlight.</param>
            /// <param name="color">The highlight color (default is yellow).</param>
            public static void HighlightElement(IWebDriver driver, IWebElement element, string color = "yellow")
            {
                ExecuteScript(driver, $"arguments[0].style.backgroundColor = '{color}';", element);
            }

            /// <summary>
            /// Removes the 'readonly' attribute from an input field.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The input element.</param>
            public static void RemoveReadonlyAttribute(IWebDriver driver, IWebElement element)
            {
                ExecuteScript(driver, "arguments[0].removeAttribute('readonly');", element);
            }

            /// <summary>
            /// Sets a value to an input field using JavaScript.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The input element.</param>
            /// <param name="value">The value to set.</param>
            public static void SetValue(IWebDriver driver, IWebElement element, string value)
            {
                ExecuteScript(driver, "arguments[0].value = arguments[1];", element, value);
            }

            /// <summary>
            /// Retrieves the inner text of an element.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The element whose inner text to retrieve.</param>
            /// <returns>The inner text of the element.</returns>
            public static string GetInnerText(IWebDriver driver, IWebElement element)
            {
                return ExecuteScript(driver, "return arguments[0].innerText;", element).ToString();
            }

            /// <summary>
            /// Scrolls the page by the specified x and y offsets.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="x">The horizontal scroll offset.</param>
            /// <param name="y">The vertical scroll offset.</param>
            public static void ScrollByOffset(IWebDriver driver, int x, int y)
            {
                ExecuteScript(driver, $"window.scrollBy({x}, {y});");
            }

            /// <summary>
            /// Clicks an element using JavaScript.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The element to click.</param>
            public static void ClickElement(IWebDriver driver, IWebElement element)
            {
                ExecuteScript(driver, "arguments[0].click();", element);
            }

            /// <summary>
            /// Returns the value of a specified attribute of an element.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The element whose attribute value to retrieve.</param>
            /// <param name="attributeName">The name of the attribute.</param>
            /// <returns>The value of the attribute.</returns>
            public static string GetAttribute(IWebDriver driver, IWebElement element, string attributeName)
            {
                return ExecuteScript(driver, "return arguments[0].getAttribute(arguments[1]);", element, attributeName).ToString();
            }

            /// <summary>
            /// Scrolls the page to the bottom.
            /// </summary>
            public static void ScrollToBottom(IWebDriver driver)
            {
                ExecuteScript(driver, "window.scrollTo(0, document.body.scrollHeight);");
            }

            /// <summary>
            /// Scrolls the page to the top.
            /// </summary>
            public static void ScrollToTop(IWebDriver driver)
            {
                ExecuteScript(driver, "window.scrollTo(0, 0);");
            }

            /// <summary>
            /// Checks if the page is fully loaded.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <returns>True if the page is loaded; otherwise, false.</returns>
            public static bool IsPageLoaded(IWebDriver driver)
            {
                string state = ExecuteScript(driver, "return document.readyState;").ToString();
                return state.Equals("complete", StringComparison.OrdinalIgnoreCase);
            }

            /// <summary>
            /// Fetches the browser's console logs.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <returns>A list of console log entries.</returns>
            public static string GetConsoleLogs(IWebDriver driver)
            {
                return ExecuteScript(driver, "return window.console.log(arguments);").ToString();
            }

            /// <summary>
            /// Simulates a mouse hover over the specified element.
            /// </summary>
            /// <param name="driver">The WebDriver instance.</param>
            /// <param name="element">The element to hover over.</param>
            public static void HoverOverElement(IWebDriver driver, IWebElement element)
            {
                string script = @"
                var event = new MouseEvent('mouseover', {
                    view: window,
                    bubbles: true,
                    cancelable: true
                });
                arguments[0].dispatchEvent(event);";
                ExecuteScript(driver, script, element);
            }

            /// <summary>
            /// Simulates a double-click on the specified element.
            /// </summary>
            public static void DoubleClickElement(IWebDriver driver, IWebElement element)
            {
                string script = @"
                var event = new MouseEvent('dblclick', {
                    view: window,
                    bubbles: true,
                    cancelable: true
                });
                arguments[0].dispatchEvent(event);";
                ExecuteScript(driver, script, element);
            }

            /// <summary>
            /// Scrolls horizontally to a specific element.
            /// </summary>
            public static void ScrollToElementHorizontally(IWebDriver driver, IWebElement element)
            {
                ExecuteScript(driver, "arguments[0].scrollIntoView({block: 'nearest', inline: 'center'});", element);
            }
        }
    }
}
