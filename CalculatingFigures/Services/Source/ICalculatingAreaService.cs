using CalculatingFigures.Figures.Source;

namespace CalculatingFigures.Services.Source;

public interface ICalculatingAreaService
{
    double CalculateArea(IAreaFigure figure);
}