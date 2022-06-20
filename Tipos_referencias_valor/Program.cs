using System;

namespace Tipos_referencias_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 20;
            p.Y = 10;

            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            double? x = null;
            double? y = 80;

            Console.WriteLine(x.HasValue);
            Console.WriteLine(x.GetValueOrDefault());

            if (x.HasValue)
            
                Console.WriteLine(x.Value);
            
            else
            
                Console.WriteLine("x is null");
            

           /* if (y.HasValue)
            
                Console.WriteLine(y.Value);
            
            else
            
                Console.WriteLine("y is null"); */

            y = x ?? 74;
            x = y ?? 10;
            Console.WriteLine(y);
            Console.WriteLine(x);

            Console.WriteLine();
            
        }
    }
}
