namespace CursoGit;

public class Calculator : ICalculator
{
    public double Abs(double x, int module)
    {
        throw new NotImplementedException();
    }

    public double Add(double a, double y)
    {
        return(a + y);
    }

    public double Div(double x, double y)
    {
        if(y != 0)
            return x/y;

        throw new DivideByZeroException();
    }

    public double Mult(double x, double y)
    {
        return x*y;
    }

     public double AddMod(double a, double y, int mod)
     {
          return (a + y) % mod;
     }

     public double MultMod(double x, double y, int mod)
     {
         return (x * y) % mod;
     }

     public double DivMod(double x, double y, int mod)
     {
        if(y != 0)
             return (x / y) % mod;

        throw new DivideByZeroException();
     }

     public double AbsMod(double x, int module, int mod)
     {
         return x%mod;
     }

    public double Pow(double x, int n)
    {
        return Math.Pow(x, n);
    }
}

