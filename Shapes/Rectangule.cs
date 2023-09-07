namespace CursoGit.Shapes
{
    public class Rectangule : IShapes
    {
        public double Area(double x, double y)
        {
            return x * y;
        }

        public double Perimeter(double x, double y)
        {
            return 2 * (x + y);
        }
    }
}