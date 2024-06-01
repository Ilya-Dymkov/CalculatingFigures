using CalculatingFigures.Figures.FiguresSource;

namespace CalculatingFigures.Figures;

public class Circle : ICalculatingArea, ICalculatingPerimeter
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
                throw new ArgumentException("The radius of the circle is set incorrectly!");
            
            _radius = value;
        }
    }

    public Circle(double radius) => Radius = radius;

    public double CalculatingArea() => Radius * Radius * Math.PI;

    public double CalculatingPerimeter() => 2 * Math.PI * Radius;
}