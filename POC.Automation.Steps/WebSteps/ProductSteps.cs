using POC.Automation.Web.Pages;
using TechTalk.SpecFlow;

namespace POC.Automation.Steps.WebSteps
{
    [Binding]
    public sealed class ProductSteps : BaseSteps
    {
        public ProductSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [StepDefinition(@"I add '([^']+?)' to cart")]
        public void AddIten(string itemName)
        {
            Products products = new Products();
            products.AddToCart(itemName);
        }
    }
}
