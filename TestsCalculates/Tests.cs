using CalculatingFigures.FigureExtensions;
using CalculatingFigures.Figures;
using CalculatingFigures.Proxies;
using CalculatingFigures.Services.Source;

namespace TestsCalculates;

public class Tests
{
    private readonly ICalculatingAreaService _calculatingAreaService = new CalculatingAreaServiceProxy();
    
    [TestCase(3d, 28.27d)]
    public void TestCalculateCircleArea(double radius, double area) =>
        Assert.That(_calculatingAreaService.CalculateArea(new Circle(radius)), Is.EqualTo(area).Within(0.01));
    
    [TestCase(3d, 4d, 5d, 6d)]
    public void TestCalculateTriangleArea(double sideA, double sideB, double sideC, double area) =>
        Assert.That(_calculatingAreaService.CalculateArea(new Triangle(sideA, sideB, sideC)), Is.EqualTo(area).Within(0.01));
    
    [TestCase(3d, 4d, 5d, true)]
    public void TestIsRightAngledTriangle(double sideA, double sideB, double sideC, bool isRightAngled) =>
        Assert.That(new Triangle(sideA, sideB, sideC).IsRightAngledTriangle(), Is.EqualTo(isRightAngled));
}