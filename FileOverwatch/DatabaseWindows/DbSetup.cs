using System.Configuration;

namespace DatabaseWindows
{
    public class DbSetup
    {
        public static void ChangeDataBasePath(string path)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["DataBase"].ConnectionString = "Data Source=" + path;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
