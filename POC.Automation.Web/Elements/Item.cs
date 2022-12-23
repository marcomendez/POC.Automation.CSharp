using POC.Automation.Helpers.Enums;

namespace POC.Automation.Web.Elements
{
    /// <summary>
    /// Handle Item type element.
    /// </summary>
    public class Item :  WebElement
    {
        public Item(string name, Locator locator) : base(name, ElementType.Item, locator)
        {
        }

        /// <summary>
        /// Clicks on Add to Cart button.
        /// </summary>
        public void AddToCart()
        {
            Element.Click();
        }
    }
}
