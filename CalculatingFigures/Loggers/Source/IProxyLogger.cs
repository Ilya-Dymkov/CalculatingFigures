using Microsoft.Extensions.Logging;

namespace CalculatingFigures.Loggers.Source;

public interface IProxyLogger
{
    void Log(LogLevel level, string message);
}