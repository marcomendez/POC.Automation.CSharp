using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Interfaces;


namespace POC.Automation.Web.Elements
{
    /// <summary>
    /// Handle Icon type element.
    /// </summary>
    public class Icon : WebElement, IClickeable
    {
        public Icon(string name, Locator locator) : base(name, ElementType.Button, locator)
        {
        }

        /// <summary>
        /// Clicks on Element.
        /// </summary>
        public void Click()
        {
            Element.Click();
        }
    }
}
