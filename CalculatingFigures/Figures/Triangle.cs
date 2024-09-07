using CalculatingFigures.Figures.Source;

namespace CalculatingFigures.Figures;

public class Triangle : IAreaFigure, IPerimeterFigure
{
    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SetSides(sideA, sideB, sideC);
    }

    private void SetSides(double sideA, double sideB, double sideC)
    {
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA ||
            sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("The side of the triangle is set incorrectly!");
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public string GetParameters() => 
        $"{nameof(SideA)}: {SideA}, {nameof(SideB)}: {SideB}, {nameof(SideC)}: {SideC}";

    public double GetArea()
    {
        var p = GetPerimeter() / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public double GetPerimeter() => SideA + SideB + SideC;
}