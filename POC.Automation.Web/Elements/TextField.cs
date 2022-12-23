using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Interfaces;

namespace POC.Automation.Web.Elements
{
    /// <summary>
    /// Handles Textfield type element.
    /// </summary>
    public class TextField : WebElement, ITexteable
    {
        public TextField(string name, Locator locator) 
            : base(name, ElementType.TextField, locator)
        {
        }

        /// <summary>
        /// Gets text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetText()
        {
           return Element.Text;
        }

        /// <summary>
        /// Sets text
        /// </summary>
        /// <param name="text">Text to set.</param>
        public void SetText(string text)
        {
            Element.Clear();
            Element.SendKeys(text);
        }
    }
}
