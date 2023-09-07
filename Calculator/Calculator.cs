namespace CursoGit;

public class Calculator : ICalculator
{
    public double Abs(double x, int module)
    {
        return x % module;
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
          throw new NotImplementedException(); 
     }

     public double MultMod(double x, double y, int mod)
     {
         throw new NotImplementedException(); 
     }

     public double DivMod(double x, double y, int mod)
     {
         throw new NotImplementedException(); 
     }

     public double AbsMod(double x, int module, int mod)
     {
         return (x - module) % mod; 
     }

    public double Pow(double x, int n)
    {
        throw new NotImplementedException();
    }
}

