using POC.Automation.Web.Interfaces;
using POC.Automation.Helpers.Enums;

namespace POC.Automation.Web.Elements
{
    /// <summary>
    /// Handles Label type elements.
    /// </summary>
    public class Label : WebElement, ILabel
    {
        public Label(string name,  Locator locator) : base(name, ElementType.Label, locator)
        {
        }

        /// <summary>
        /// Get text from web element.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetText()
        {
            return Element.Text;
        }
    }
}
