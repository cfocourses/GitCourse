using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGit.Shapes
{
    public class Circle : IShapes
    {
        public double Area(double x, double y)
        {
            return Math.PI * x * x;
        }

        public double Perimeter(double x, double y)
        {
            return 2 * Math.PI * x;
        }
    }
}
