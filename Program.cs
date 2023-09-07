
using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator  c = new Calculator();
        double add1= c.Add(5.1 , 5.4);
        Console.WriteLine("Add1= " + add1);
        double add2= c.Add(5.5 , 5.9);
        Console.WriteLine("Add1= " + add2);
    }



}