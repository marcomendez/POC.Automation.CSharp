using NUnit.Framework;
using POC.Automation.Web.Drivers;
using POC.Automation.Web.Elements;
using POC.Automation.Web.Interfaces;
using System.Threading;
using TechTalk.SpecFlow;

namespace POC.Automation.Steps
{
    [Binding]
    public sealed class GenericSteps : BaseSteps
    {
        public GenericSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [StepDefinition(@"I navigate to Login")]
        public void NavigateToClickUp()
        {
            WebDriverManager.Instance.Start();
        }

        [StepDefinition(@"I set '([^']+?)' in ([^']+?)(?: on ([^']+?)|)")]
        public void SetText(string text, string elementName, string PageName)
        {
            ITexteable texteable = (ITexteable) Element(elementName, PageName);
            texteable.SetText(text);
        }

        [StepDefinition(@"I click ([^']+?)(?: on ([^']+?)|)")]
        public void Click(string elementName, string PageName)
        {
            IClickeable clickeable = (IClickeable) Element(elementName, PageName);
            clickeable.Click();
        }

        [StepDefinition(@"I should see '([^']+?)' displayed(?: on ([^']+?)|)")]
        public void VerifyThatElementIsDisplayed(string elementName, string PageName)
        {
            bool status = Element(elementName, PageName).Displayed();
            Assert.IsTrue(status, $"The element {elementName} was not displayed.");
        }


        [StepDefinition(@"I should see the following text '([^']+?)' displayed")]
        public void VerifyThatTextDisplayed(string text)
        {
            string xpath = $"//*[contains(text(),'{text}')]";
            Label label = new Label(string.Empty, new Locator(Helpers.Enums.LocatorType.XPath, xpath));

            bool status = label.Displayed();
            Assert.IsTrue(status, $"The element {text} was not displayed.");
        }
    }
}
