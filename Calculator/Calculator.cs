namespace CursoGit;

public class Calculator : ICalculator
{
    public double Abs(double x, int module)
    {
        throw new NotImplementedException();
    }

    public double Add(double a, double y)
    {
        throw new NotImplementedException();
    }

    public double Div(double x, double y)
    {
        throw new NotImplementedException();
    }

    public double Mult(double x, double y)
    {
        throw new NotImplementedException();
    }

     public double AddMod(double a, double y, int mod)
     {
        return a % mod + y % mod;
     }

     public double MultMod(double x, double y, int mod)
     {
         return x * y % mod;
     }

     public double DivMod(double x, double y, int mod)
     {
         return x % mod / y % mod;
     }

     public double AbsMod(double x, int module, int mod)
     {
         return Math.Abs(x) % mod;
     }

    public double Pow(double x, int n)
    {
        return Math.Pow(x, n);
    }
}

