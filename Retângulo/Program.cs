using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a altura do retângulo");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a largura do retângulo");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area: {ret.AreaRetângulo().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro: {ret.PerRetângulo().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}





