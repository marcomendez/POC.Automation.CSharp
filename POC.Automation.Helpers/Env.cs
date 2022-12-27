using System.Configuration;

namespace POC.Automation.Helpers
{
    public class Env
    {
        #region Web
        public static string WebAppUrl = GetKeyName(Keys.WebAppUrl);
        public static string UserName = GetKeyName(Keys.UserName);
        public static string Password = GetKeyName(Keys.Password);
        public static string ImplicitWait = GetKeyName(Keys.ImplicitWait);
        #endregion


        #region Mobile
        public static string PlatformName = GetKeyName(Keys.PlatformName);
        public static string DeviceName = GetKeyName(Keys.DeviceName);
        public static string PlatformVersion = GetKeyName(Keys.PlatformVersion);
        public static string BrowserName = GetKeyName(Keys.BrowserName);
        public static string IPDevice = GetKeyName(Keys.IPDevice);
        #endregion


        /// <summary>
        /// Gets Value from App.config.
        /// </summary>
        /// <param name="keyName">keyname to get value.</param>
        /// <returns>String with value from app.config.</returns>
        private static string GetKeyName(string keyName)
        {
            return ConfigurationManager.AppSettings[keyName];
        }
    }
}
