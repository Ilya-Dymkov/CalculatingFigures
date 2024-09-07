using CalculatingFigures.Figures;

namespace CalculatingFigures.FigureExtensions;

public static class TriangleExtensions
{
    public static bool IsRightAngledTriangle(this Triangle triangle) => 
        Math.Abs(triangle.SideA * triangle.SideA + triangle.SideB * triangle.SideB - triangle.SideC * triangle.SideC) < 0.01;
}