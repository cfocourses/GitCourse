using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        //Invocar 2 ejemplos para cada operación de la clas Calculator.
        var calculator = new Calculator();
        var num1 = 5;
        var num2 = 2;
        var num3 = -2.5;

        var abs = calculator.Abs(num3, num1);

        Console.WriteLine($"Valor absoluto de {num3} es : " + abs);

        try
        {
            var div = calculator.Div(num1, num2);

            Console.WriteLine($"{num1} dividido {num2} es: " + div);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("No se puede dividir por cero");
        }
    }
}