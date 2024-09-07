using CalculatingFigures.Figures;
using CalculatingFigures.Figures.Source;
using CalculatingFigures.Proxies;

var calculatingAreaService = new CalculatingAreaServiceProxy();

while (true)
{
    Console.WriteLine("Select a figure:");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Triangle");

    switch (GetConsoleValue<int>("Figure number"))
    {
        case 1:
            WriteArea(new Circle(GetConsoleValue<double>("Radius")));
            break;
        case 2:
            WriteArea(new Triangle(
                GetConsoleValue<double>("SideA"),
                GetConsoleValue<double>("SideB"),
                GetConsoleValue<double>("SideC")));
            break;
        default:
            Console.WriteLine("There is no such figure\n");
            break;
    }
    
    Console.Write("Do you want to continue? (y/n): ");
    if (Console.ReadLine()?.ToLower() != "y") break;
    Console.WriteLine();
}

return;

TReturn GetConsoleValue<TReturn>(string message)
{
    Console.Write(message + ": ");
    
    try
    {
        return (TReturn)Convert.ChangeType(Console.ReadLine(), typeof(TReturn));
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

void WriteArea(IAreaFigure figure) => 
    Console.WriteLine($"The area of the {figure.GetType().Name} is {calculatingAreaService.CalculateArea(figure)}\n");