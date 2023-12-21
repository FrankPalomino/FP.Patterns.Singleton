namespace FP.Patterns.Singleton.Exercice2
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _config;
        public string DataBase { get; set; }
        public string User { get; set; }

        private ConfigurationManager() { }

        public static ConfigurationManager Instance()
        {
            if (_config is null)
            {
                _config = new ConfigurationManager();
            }
            return _config;
        }
    }
}
