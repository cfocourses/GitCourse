using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGit.Shapes
{
    internal class Triangule :IShapes
    {
        double Lado1(double x, double y);
        double Lado2(double x, double y);
        double Lado3(double x, double y);

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3();
        }
    }
}
