using CursoGit;
using CursoGit.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        var calculator = new Calculator();
        var circle = new Circle();
        var triangle = new Triangule();

        Console.WriteLine($"3 + 5: {calculator.Add(3, 5)}");
        Console.WriteLine($"6^2: {calculator.Pow(6, 2)}");

        Console.WriteLine();
        Console.WriteLine($"Area de circulo r5: {circle.Area(5,5)}");
        Console.WriteLine($"Perimetro de triangulo b3 h4: {triangle.Perimeter(3,4)}");
    }
}