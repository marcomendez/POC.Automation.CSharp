using POC.Automation.Helpers.Attributes;
using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Elements;
using POC.Automation.Web.Interfaces;

namespace POC.Automation.Web.Pages
{
    [Page("Login")]
    public class Login
    {
        [Element("UserName", ElementType.TextField)]
        [Locator(LocatorType.Id, "user-name")]
        public ITexteable UserName { get; }

        [Element("Password", ElementType.TextField)]
        [Locator(LocatorType.Id, "password")]
        public ITexteable Password { get; }

        [Element("Login", ElementType.Button)]
        [Locator(LocatorType.Id, "login-button")]
        public IClickeable LoginBtn { get; }
    }
}
