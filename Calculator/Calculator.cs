namespace CursoGit;

public class Calculator : ICalculator
{
    public double Abs(double x, int module)
    {
        return x < 0 ? x * (-1) : x;
    }

    public double Add(double a, double y)
    {
        return y + a;
    }

    public double Div(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        else
        {
            return x / y;
        }
    }

    public double Mult(double x, double y)
    {
        return y * x;
    }

    public double AddMod(double a, double y, int mod)
    {
        double suma = a + y;

        double resultado = suma % mod;

        if (resultado < 0)
        {
            resultado += mod;
        }

        return resultado;
    }

    public double MultMod(double x, double y, int mod)
    {
        double multiplicacion = x * y;

        double resultado = multiplicacion % mod;

        if (resultado < 0)
        {
            resultado += mod;
        }

        return resultado;
    }
    public double DivMod(double x, double y, int mod)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("La división por cero no está permitida.");
        }

        double inversoY = ModInverse(y, mod);

        double resultado = x * inversoY;

        resultado = resultado % mod;

        if (resultado < 0)
        {
            resultado += mod;
        }

        return resultado;
    }

    private double ModInverse(double a, int mod)
    {
        int m = mod;
        int m0 = m, x0 = 0, x1 = 1;

        while (a > 1)
        {
            int q = (int)(a / m);
            int t = m;
            m = (int)(a % m);
            a = t;
            t = x0;
            x0 = x1 - q * x0;
            x1 = t;
        }

        if (x1 < 0)
        {
            x1 += m0;
        }

        return x1;
    }

    public double AbsMod(double x, int module, int mod)
    {
        if (module < 1 || mod <= 0)
        {
            throw new ArgumentException("Los argumentos module y mod deben ser números positivos.");
        }

        double closestMultiple = Math.Floor(x / mod) * mod;

        double distance = Math.Abs(x - closestMultiple);

        if (distance > mod / 2)
        {
            distance = mod - distance;
        }

        return distance;
    }

    public double Pow(double x, int n)
    {
        if (n == 0)
        {
            return 1.0; 
        }
        else if (n < 0)
        {
            return 1.0 / Pow(x, -n);
        }
        else
        {
            double halfPow = Pow(x, n / 2);
            if (n % 2 == 0)
            {
                return halfPow * halfPow;
            }
            else
            {
                return halfPow * halfPow * x;
            }
        }
    }
}