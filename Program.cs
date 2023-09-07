using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        var calculator = new Calculator();

        Console.WriteLine($"3 + 5: {calculator.Add(3, 5)}");
    }
}