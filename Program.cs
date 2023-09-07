using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator c = new Calculator();
        double abs1 = c.Abs(2,7);
        double abs2 = c.Abs(8, 9);
        Console.WriteLine("Abs1="+ abs1);
        Console.WriteLine("Abs2=" + abs2);
        double absMod1= c.AbsMod(7,9,3);
        double absMod2 = c.AbsMod(2, 1, 0);
        Console.WriteLine("absMod1 = "+ absMod1);
        Console.WriteLine("absMod2 = " + absMod2);
    }



}