namespace CursoGit.Shapes
{
    public class Rectagule : IShapes
    {
        public double Area(double x, double y)
        {
            return x * y;
        }

        public double Perimeter(double x, double y)
        {
            return (x * 2) + (y * 2);
        }
    }
}