using CalculatingFigures.Figures.Source;

namespace CalculatingFigures.Figures;

public class Circle : IAreaFigure, IPerimeterFigure
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0) throw new ArgumentException("The radius of the circle is set incorrectly!");
            
            _radius = value;
        }
    }
    
    public string GetParameters() => $"{nameof(Radius)}: {Radius}";

    public Circle(double radius) => Radius = radius;

    public double GetArea() => Radius * Radius * Math.PI;

    public double GetPerimeter() => 2 * Math.PI * Radius;
}