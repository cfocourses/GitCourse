using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGit.Shapes
{
    internal class Circle : IShapes
    {
        //jeflkdsjflksd
        public double Area(double x, double y)
        {
            return Math.PI * Math.Pow(x,2);
        }

        public double Perimeter(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
