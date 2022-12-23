using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Interfaces;

namespace POC.Automation.Web.Elements
{
    /// <summary>
    /// Handles button type elements.
    /// </summary>
    public class Button : WebElement, IClickeable
    {
        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="name">Name to call to locator.</param>
        /// <param name="locator">Locator info.</param>
        public Button(string name, Locator locator) : base(name, ElementType.Button, locator)
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
