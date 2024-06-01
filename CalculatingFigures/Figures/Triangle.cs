using CalculatingFigures.Figures.FiguresSource;

namespace CalculatingFigures.Figures;

public class Triangle : ICalculatingArea, ICalculatingPerimeter
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public double SideA
    {
        get => _sideA;
        set
        {
            if (value <= 0 || SideB + SideC <= value)
                throw new ArgumentException("The side of the triangle is set incorrectly!");
            
            _sideA = value;
        }
    }
    
    public double SideB
    {
        get => _sideB;
        set
        {
            if (value <= 0 || SideA + SideC <= value)
                throw new ArgumentException("The side of the triangle is set incorrectly!");
            
            _sideB = value;
        }
    }
    
    public double SideC
    {
        get => _sideC;
        set
        {
            if (value <= 0 || SideA + SideB <= value)
                throw new ArgumentException("The side of the triangle is set incorrectly!");
            
            _sideC = value;
        }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double CalculatingArea()
    {
        var p = CalculatingPerimeter() / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public double CalculatingPerimeter() => SideA + SideB + SideC;
}