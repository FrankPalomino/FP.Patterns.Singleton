namespace FP.Patterns.Singleton.Exercice3
{
    public class Logger
    {
        private static Logger _logger;
        private readonly List<Log> _logs = [];

        private Logger() { }

        public static Logger GetInstance()
        {
            _logger ??= new Logger();

            return _logger;
        }

        public List<Log> GetLog()
        {
            return _logs;
        }

        public void AddLog(Log log)
        {
            _logs.Add(log);
        }
    }
}
