using POC.Automation.Helpers.Attributes;
using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Elements;
using POC.Automation.Web.Interfaces;

namespace POC.Automation.Web.Pages
{
    [Page("Products")]
    public class Products
    {
        [Element("Cart Icon", ElementType.Icon)]
        [Locator(LocatorType.Id, "shopping_cart_container")]
        public IClickeable LoginBtn { get; }

        /// <summary>
        /// Add items to shopping cart.
        /// </summary>
        /// <param name="itemName">Item name</param>
        public void AddToCart(string itemName)
        {
            string xpath = $"//*[contains(text(),'{itemName}')]/../../following-sibling::div/*[contains(text(),'Add to cart')]";
            Item item = new Item(itemName, new Locator(LocatorType.XPath, xpath));
            item.AddToCart();
        }
    }
}