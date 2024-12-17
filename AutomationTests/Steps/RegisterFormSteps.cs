using Automation.PageObjects.Registration;
using AutomationCore.Helpers;
using BoDi;
using TechTalk.SpecFlow;

namespace Automation.Tests.Steps
{
    [Binding]
    public class RegisterFormSteps : BaseSteps
    {
        readonly RegisterFormPage registerFormPage;
        protected RegisterFormSteps(IObjectContainer container, ScenarioContext scenarioContext) : base(container, scenarioContext)
        {
            registerFormPage = new RegisterFormPage(driver);
        }

        [When(@"I fill out the register form")]
        public void FillForm()
        {
            registerFormPage.SetFirstName(Randomizer.GetRandomString(5));
            registerFormPage.SetLastName(Randomizer.GetRandomString(5));
            registerFormPage.SetEmail(Randomizer.GetRandomEmail());
            registerFormPage.SetPhone(Randomizer.GetRandomPhoneNumber());
            List<string> genderValues = new List<string>() { "Male", "FeMale"};
            registerFormPage.SetGender(Randomizer.GetRandomValue(genderValues));
            registerFormPage.SetCountry("Select Country");
            var password = Randomizer.GetRandomString(5);
            registerFormPage.SetPassword(password);
            registerFormPage.SetConfirmPassword(password);
            registerFormPage.Submit();
        }
    }
}
