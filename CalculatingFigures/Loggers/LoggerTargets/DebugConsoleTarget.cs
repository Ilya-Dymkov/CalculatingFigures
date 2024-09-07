using System.Diagnostics;
using CalculatingFigures.Loggers.LoggerTargets.Source;
using Microsoft.Extensions.Logging;

namespace CalculatingFigures.Loggers.LoggerTargets;

public class DebugConsoleTarget : ILoggerTarget
{
    public void WriteLog(LogLevel level, string message) => 
        Debug.WriteLine($"[{level}]: {message}");
}