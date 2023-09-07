
using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        //Invocar 2 ejemplos para cada operación de la clas Calculator.
        Calculator  c = new Calculator();
        c.Mult(2,5);
        Calculator  c = new Calculator();
        double add1= c.Add(5.1 , 5.4);
        Console.WriteLine("Add1= " + add1);
        double add2= c.Add(5.5 , 5.9);
        Console.WriteLine("Add1= " + add2);
    }



}