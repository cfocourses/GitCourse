using CursoGit;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator c = new Calculator();
        c.Abs(2,7);
        c.Abs(8, 9);
        c.Abs(3, 2);
        c.Abs(0, 1);
        c.AbsMod(1, 5, 7);
        c.AbsMod(7,9,3);
        c.AbsMod(2, 1, 0);
    }



}