namespace SingletonPattern
{
    public class Logger
    {
        private static readonly object LockObject = new();
        private static Logger _instance;
        private LogLevel _logLevel = LogLevel.INFO;

        private Logger() { }

        public static Logger GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void SetLogLevel(LogLevel logLevel)
        {
            _logLevel = logLevel;
        }

        public void LogDebug(string message)
        {
            if (_logLevel <= LogLevel.DEBUG)
            {
                Console.WriteLine("DEBUG: " + message);
            }
        }

        public void LogInfo(string message)
        {
            if (_logLevel <= LogLevel.INFO)
            {
                Console.WriteLine("INFO: " + message);
            }
        }

        public void LogWarn(string message)
        {
            if (_logLevel <= LogLevel.WARN)
            {
                Console.WriteLine("WARN: " + message);
            }
        }

        public void LogError(string message)
        {
            if (_logLevel <= LogLevel.ERROR)
            {
                Console.WriteLine("ERROR: " + message);
            }
        }
    }
}
