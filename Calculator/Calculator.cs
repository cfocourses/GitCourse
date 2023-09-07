namespace CursoGit;

public class Calculator : ICalculator
{
    public double Abs(double x, int module)
    {
        throw new NotImplementedException();
    }

    public double Add(double a, double y)
    {
        return a + y;
    }

    public double Div(double x, double y)
    {
        double resp=0;
       return resp=x/y;
    }

    public double Mult(double x, double y)
    {
         return x*y;
      
    }

    public double AddMod(double a, double y, int mod) => (a + y) % mod; 

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
         throw new NotImplementedException(); 
     }

    public double Pow(double x, int n)
    {
        throw new NotImplementedException();
    }
}

