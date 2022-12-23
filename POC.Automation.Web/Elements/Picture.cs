using System;
using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Interfaces;

namespace POC.Automation.Web.Elements
{
   
    public class Picture : WebElement, IImage
    {
        public Picture(string name, Locator locator) : base(name, ElementType.Button, locator)
        {
        }
    }
}
