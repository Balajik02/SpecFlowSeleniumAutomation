using AutomationCore.Waiters;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace AutomationCore.Elements
{
    public class Link : BaseControl
    {
        public Link(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        // Find link by its text
        public IWebElement FindLinkByText(string linkText)
        {
            try
            {
                return Waiter.WaitForElementToBeVisible(_driver, By.LinkText(linkText));
            }
            catch (WebDriverTimeoutException)
            {
                throw new NoSuchElementException($"Link with text '{linkText}' not found.");
            }
        }

        // Find link by partial text
        public IWebElement FindLinkByPartialText(string partialLinkText)
        {
            try
            {
                return Waiter.WaitForElementToBeVisible(_driver, By.PartialLinkText(partialLinkText));
            }
            catch (WebDriverTimeoutException)
            {
                throw new NoSuchElementException($"Link with partial text '{partialLinkText}' not found.");
            }
        }

        // Click a link by text
        public void ClickLinkByText(string linkText)
        {
            var link = FindLinkByText(linkText);
            link.Click();
        }

        // Click a link by partial text
        public void ClickLinkByPartialText(string partialLinkText)
        {
            var link = FindLinkByPartialText(partialLinkText);
            link.Click();
        }

        // Verify if the link is displayed
        public bool IsLinkDisplayed(string linkText)
        {
            try
            {
                var link = FindLinkByText(linkText);
                return link.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        // Get the href (URL) attribute of the link
        public string GetLinkUrl(string linkText)
        {
            var link = FindLinkByText(linkText);
            return link.GetDomAttribute("href");
        }

        // Get all links on the page using LINQ
        public List<string> GetAllLinks()
        {
            try
            {
                // Find all anchor tags (<a>) on the page
                var anchorElements = Waiter.WaitForCondition(_driver, ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("a")));

                // Use LINQ to get the href attributes of all the anchor elements
                var links = anchorElements
                            .Where(anchor => !string.IsNullOrEmpty(anchor.GetDomAttribute("href")))  // Filter out empty hrefs
                            .Select(anchor => anchor.GetDomAttribute("href")) // Select href attributes
                            .ToList(); // Convert to a List<string>

                return links;
            }
            catch (WebDriverTimeoutException)
            {
                throw new NoSuchElementException("No links found on the page.");
            }
        }
    }
}