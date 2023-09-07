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
        try{
             return x / y;   
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por 0");
            return 0;
        }
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
         throw new NotImplementedException(); 
     }

    public double Pow(double x, int n)
    {
        Math return.Pow(x.n);
    }
}

