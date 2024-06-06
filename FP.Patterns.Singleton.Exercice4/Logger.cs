namespace FP.Patterns.Singleton.Exercice4
{
    public class Logger
    {
        private static Logger _logger;
        private List<string> _logs;

        private Logger() 
        {
            _logs = new List<string>();
        }

        public static Logger GetLogger()
        {
            if(_logger is null)
            {
                _logger = new Logger();
            }
            return _logger;
        }

        public void Log(string message)
        {
            _logs.Add(message);
        }

        public void ShowLogs()
        {
            foreach(string log in _logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
