using CalculatingFigures.Figures.Source;
using CalculatingFigures.Services.Source;

namespace CalculatingFigures.Services;

public class CalculatingAreaService : ICalculatingAreaService
{
    public double CalculateArea(IAreaFigure figure) => figure.GetArea();
}