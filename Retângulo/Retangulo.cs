using System.Globalization;

namespace Course
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double AreaRetângulo()
        {
            return Altura * Largura;
        }

        public double PerRetângulo()
        {
            return (Largura * 2) + (Altura * 2);
        }

    }
}
