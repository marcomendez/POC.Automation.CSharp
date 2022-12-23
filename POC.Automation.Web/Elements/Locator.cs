using OpenQA.Selenium;
using POC.Automation.Helpers.Enums;
using System;

namespace POC.Automation.Web.Elements
{
    /// <summary>
    /// Handle Locator information.
    /// </summary>
    public class Locator
    {
        public LocatorType Type { get; set; }

        public string Value { get; set; }

        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="type">Locator type. (e. Xpath, Id, Css.).</param>
        /// <param name="value">Value to find locator.</param>
        public Locator(LocatorType type, string value)
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// Gets By instance of locator.
        /// </summary>
        /// <returns>By class instance of locator.</returns>
        public By GetBy()
        {
            switch (Type)
            {
                case LocatorType.XPath:
                    return By.XPath(Value);

                case LocatorType.Name:
                    return By.Name(Value);

                case LocatorType.Id:
                    return By.Id(Value);

                case LocatorType.ClassName:
                    return By.ClassName(Value);

                case LocatorType.CssSelector:
                    return By.CssSelector(Value);

                default:
                    throw new Exception($"Cannot get '{typeof(By)}' object for '{Type}'.");
            }
        }
    }
}
