public interface ICalculator
{
    /// <summary>
    /// Suma algebraica
    /// </summary>
    /// <param name="a"></param>
    /// <param name="y"></param>
    /// <returns></returns>
     double Add(double a, double y);

     double Mult(double x, double y);

     double Div(double x, double y);

     double Abs(double x, int module);

     double AddMod(double a, double y, int mod);

     double MultMod(double x, double y, int mod);

     double DivMod(double x, double y, int mod);

     double AbsMod(double x, int module, int mod);

    double Pow(double x, int n);

    int ToCube(int num);
}
