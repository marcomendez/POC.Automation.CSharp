using POC.Automation.Helpers.Enums;
using POC.Automation.Web.Drivers;
using POC.Automation.Web.Interfaces;
using System.Threading;

namespace POC.Automation.Web.Elements
{

    /// <summary>
    /// Handles basic WebElement actions.
    /// </summary>
    public class WebElement : IUIElement
    {
        public string Name { get; set; }
        public ElementType ElementType { get; set; }
        public Locator Locator { get; set; }

        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="type">Element type (e. Button, Label, TextBox, etc.)</param>
        /// <param name="locator">Locator informaton (e. a[href='#blockbestsellers']).</param>
        public WebElement(string name, ElementType type, Locator locator)
        {
            Thread.Sleep(2000);
            Name = name;
            ElementType = type;
            Locator = locator;
        }

        /// <summary>
        /// Gets WebElement found.
        /// </summary>
        public virtual OpenQA.Selenium.IWebElement Element
        {
            get => WebDriverManager.Instance.WebDriver.FindElement(Locator.GetBy());
        }

        /// <summary>
        /// Checks if WebElement is displayed on DOM.
        /// </summary>
        /// <returns>True if webelemenet id displayed, false otherwise.</returns>
        public bool Displayed()
        {
            try
            {
                return Element.Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}


