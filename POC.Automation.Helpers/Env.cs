using System.Configuration;

namespace POC.Automation.Helpers
{
    public class Env
    {
        #region API
        public static string ApiBaseUrl = GetKeyName(Keys.ApiBaseUrl);
        public static string Authorization = GetKeyName(Keys.Authorization);
        public static string SpaceBody = "{\"name\":\"SPACENAME\",\"multiple_assignees\":true,\"features\":{\"due_dates\":{\"enabled\":true,\"start_date\":false,\"remap_due_dates\":true,\"remap_closed_due_date\":false},\"time_tracking\":{\"enabled\":false},\"tags\":{\"enabled\":true},\"time_estimates\":{\"enabled\":true},\"checklists\":{\"enabled\":true},\"custom_fields\":{\"enabled\":true},\"remap_dependencies\":{\"enabled\":true},\"dependency_warning\":{\"enabled\":true},\"portfolios\":{\"enabled\":true}}}";
        #endregion

        #region Web
        public static string WebAppUrl = GetKeyName(Keys.WebAppUrl);
        #endregion

        public static string UserName = GetKeyName(Keys.UserName);
        public static string Password = GetKeyName(Keys.Password);
        public static string ImplicitWait = GetKeyName(Keys.ImplicitWait);

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
