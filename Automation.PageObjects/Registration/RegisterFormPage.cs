using AutomationCore.DriverService;
using AutomationCore.Elements;
using OpenQA.Selenium;

namespace Automation.PageObjects.Registration
{
    public class RegisterFormPage : BasePage
    {
        IWebDriver _driver;
        public RegisterFormPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        readonly By firstName = By.XPath("//input[@ng-model='FirstName']");
        readonly By LastName = By.XPath("//input[@ng-model='LastName']");
        readonly By phone = By.XPath("//input[@ng-model='Phone']");
        readonly By email = By.XPath("//input[@ng-model='EmailAdress']");
        readonly By country = By.Id("countries");
        By gender(string option) => By.XPath($"//input[@value='{option}']");
        By password = By.XPath("//input[@ng-model='Password']");
        By confirmPassword = By.XPath("//input[@ng-model='CPassword']");
        By submit = By.CssSelector("button#submitbtn");


        public void SetFirstName(string value)
        {
            TextBox textbox = new TextBox(_driver, firstName);
            textbox.EnterText(value);
        }

        public void SetLastName(string value)
        {
            TextBox textbox = new TextBox(_driver, LastName);
            textbox.EnterText(value);
        }

        public void SetEmail(string value)
        {
            TextBox textbox = new TextBox(_driver, email);
            textbox.EnterText(value);
        }

        public void SetPhone(string value)
        {
            TextBox textbox = new TextBox(_driver, phone);
            textbox.EnterText(value);
        }

        public void SetGender(string value)
        {
            Radio radio = new Radio(_driver, gender(value));
            radio.Select();
        }

        public void SetCountry(string value)
        {
            Select select = new Select(_driver, country);
            select.SelectByText(value);
        }

        public void SetPassword(string value)
        {
            TextBox textbox = new TextBox(_driver, password);
            textbox.EnterText(value);
        }

        public void SetConfirmPassword(string value)
        {
            TextBox textbox = new TextBox(_driver, confirmPassword);
            textbox.EnterText(value);
        }

        public void Submit()
        {
            Button button = new Button(_driver, submit);
            button.ClickButton();
        }
    }
}
