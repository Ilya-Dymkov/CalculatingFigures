using Microsoft.Extensions.Logging;

namespace CalculatingFigures.Loggers.LoggerTargets.Source;

public interface ILoggerTarget
{
    void WriteLog(LogLevel level, string message);
}