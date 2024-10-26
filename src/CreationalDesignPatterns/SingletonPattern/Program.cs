using SingletonPattern;

Logger logger = Logger.GetInstance;

logger.SetLogLevel(LogLevel.INFO);
logger.LogInfo("info logger");
logger.LogWarn("warn logger");
logger.LogError("error logger");