using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGit.Shapes
{
    public class Triangule : IShapes
    {
        public double Area(double x, double y)
        {
            return (x * y) / 2;
        }

        public double Perimeter(double x, double y)
        {
            return x + y + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
