using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using POC.Automation.Helpers;
using System;
using System.Threading;

namespace POC.Automation.Web.Drivers
{
    /// <summary>
    /// Singleton class to Manage web driver.
    /// </summary>
    public sealed class WebDriverManager
    {
        /// <summary>
        /// Privates Constructor.
        /// </summary>
        private WebDriverManager()
        { }

        private static WebDriverManager instance;
        private IWebDriver webDriver;

        /// <summary>
        /// Gets WebDriverManager Instance.
        /// </summary>
        public static WebDriverManager Instance
        {
            get => instance = instance ??= new WebDriverManager();
        }

        /// <summary>
        /// Starts, Open, navigate to Url and Maximize browser.
        /// </summary>
        public void Start()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, Env.PlatformName);
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, Env.DeviceName);
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, Env.PlatformVersion);
            driverOptions.AddAdditionalCapability(MobileCapabilityType.BrowserName, Env.BrowserName);

            webDriver = new RemoteWebDriver(new Uri($"http://{Env.IPDevice}/wd/hub"), driverOptions);
            webDriver.Navigate().GoToUrl(Env.WebAppUrl);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(int.Parse(Env.ImplicitWait));
        }

        /// <summary>
        /// Gets WebDriver instance.
        /// </summary>
        public IWebDriver WebDriver
        {
            get { return webDriver; }
        }

        /// <summary>
        /// Closes the web driver.
        /// </summary>
        public void Close()
        {
            webDriver.Close();
            webDriver.Quit();
        }
    }
}
