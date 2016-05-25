using System.Configuration;

namespace StudentManage.Common
{
    public static class AppSettings
    {
        public static int AccessTokenExpireTime
        {
            get
            {
                int result = 1; // Default access token is 1 day
                string webConfig = ConfigurationManager.AppSettings["AccessTokenExpireTime"];
                if (!string.IsNullOrEmpty(webConfig))
                {
                    int.TryParse(webConfig, out result);
                }

                return result;
            }
        }

        public static string SuperAdminEmailAddress
        {
            get
            {
                string webConfig = ConfigurationManager.AppSettings["SuperAdminEmailAddress"];
                if (string.IsNullOrEmpty(webConfig))
                {
                    webConfig = "sa@studentmanage.com";
                }

                return webConfig;
            }
        }
    }
}