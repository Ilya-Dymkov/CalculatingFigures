using CalculatingFigures.Figures;

namespace TestsCalculates;

public class Tests
{
    [Test]
    public void TestCalculateCircleArea() =>
        Assert.That(new Circle(3).CalculatingArea(), Is.EqualTo(28.27).Within(0.01));
}