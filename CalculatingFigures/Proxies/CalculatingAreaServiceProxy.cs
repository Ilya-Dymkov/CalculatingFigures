using CalculatingFigures.Figures.Source;
using CalculatingFigures.Loggers;
using CalculatingFigures.Loggers.Source;
using CalculatingFigures.Services;
using CalculatingFigures.Services.Source;
using Microsoft.Extensions.Logging;

namespace CalculatingFigures.Proxies;

public class CalculatingAreaServiceProxy : ICalculatingAreaService
{
    private readonly ICalculatingAreaService _calculatingAreaService = new CalculatingAreaService();
    private readonly IProxyLogger _logger = new ProxyLogger();
    
    public double CalculateArea(IAreaFigure figure)
    {
        try
        {
            _logger.Log(LogLevel.Information, $"Calculating area of {figure.GetType().Name} with parameters: {figure.GetParameters()}");
            return _calculatingAreaService.CalculateArea(figure);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, e.Message);
            throw;
        }
    }
}