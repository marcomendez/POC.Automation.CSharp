using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Elements;

namespace POC.Automation.Web.Interfaces
{
    public interface IUIElement
    {
        string Name { get; set; }

        ElementType ElementType { get; set; }

        Locator Locator { get; set; }
    }
}
