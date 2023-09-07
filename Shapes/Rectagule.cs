

namespace CursoGit.Shapes
{
    public interface Rectagule : IShapes
    {
        double LadoA(double x, double y);
        double LadoB(double x, double y);

        public double CalcularPerimetro()
        {
            return LadoA*2 + LadoB*2;
        }

    }
}