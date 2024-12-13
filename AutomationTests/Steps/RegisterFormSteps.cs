using BoDi;
using TechTalk.SpecFlow;

namespace Automation.Tests.Steps
{
    [Binding]
    public class RegisterFormSteps : BaseSteps
    {
        protected RegisterFormSteps(IObjectContainer container, ScenarioContext scenarioContext) : base(container, scenarioContext)
        {
        }
    }
}
