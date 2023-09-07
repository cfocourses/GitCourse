using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGit.Shapes
{
    public class Circle
    {
        public double CalculateArea(double radio)
        {
            // Área de un círculo: π * radio^2
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
