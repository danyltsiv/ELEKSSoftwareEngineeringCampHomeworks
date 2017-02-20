using System.Configuration;

namespace prac9task1MVC1
{
    public class AppSettings
    {
        private static AppSettings _instance;
        public static AppSettings Instance
        {
            get
            {
                return _instance ?? (_instance = new AppSettings());
            }
        }

        private AppSettings() { }

        public string EstablishmentFilePath
        {
            get
            {
                return ConfigurationManager.AppSettings["establishmentsFilePath"];
            }
        }
    }
}
