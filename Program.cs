using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        var calculator = new Calculator();

        Console.WriteLine($"6^2: {calculator.Pow(6, 2)}");
    }
}