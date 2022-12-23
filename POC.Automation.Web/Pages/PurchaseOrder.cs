using POC.Automation.Helpers.Attributes;
using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Interfaces;
namespace POC.Automation.Web.Pages
{

    [Page("Purchase Order")]
    public class PurchaseOrder
    {
        [Element("Checkout", ElementType.Icon)]
        [Locator(LocatorType.Id, "checkout")]
        public IClickeable Checkout{ get; }

        [Element("First Name", ElementType.TextField)]
        [Locator(LocatorType.Id, "first-name")]
        public ITexteable FirstName { get; }

        [Element("Last Name", ElementType.TextField)]
        [Locator(LocatorType.Id, "last-name")]
        public ITexteable LastName{ get; }

        [Element("Zip / Postal Code", ElementType.TextField)]
        [Locator(LocatorType.Id, "postal-code")]
        public ITexteable Zip { get; }

        [Element("Continue", ElementType.Button)]
        [Locator(LocatorType.Id, "continue")]
        public IClickeable Continue { get; }

        [Element("Finish", ElementType.Button)]
        [Locator(LocatorType.Id, "finish")]
        public IClickeable Finish { get; }

        [Element("Pony express image", ElementType.Picture)]
        [Locator(LocatorType.XPath, "//*[@src='/static/media/pony-express.46394a5d.png']")]
        public IImage Image { get; }

    }
}