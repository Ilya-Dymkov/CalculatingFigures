using CalculatingFigures.Loggers.LoggerTargets;
using CalculatingFigures.Loggers.LoggerTargets.Source;
using CalculatingFigures.Loggers.Source;
using Microsoft.Extensions.Logging;

namespace CalculatingFigures.Loggers;

public class ProxyLogger : IProxyLogger
{
    private static readonly ILoggerTarget[] LoggerTargets = [new DebugConsoleTarget()];
    
    public void Log(LogLevel level, string message)
    {
        foreach (var loggerTarget in LoggerTargets) loggerTarget.WriteLog(level, message);
    }
}