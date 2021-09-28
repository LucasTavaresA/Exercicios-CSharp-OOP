using System;
using System.Globalization;

namespace _2_triangulo {
    class Program {
        static void Main(string[] args) {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("x 1 2 3: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("y 1 2 3");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            
            p = (y.A + y.B + y.C) / 2;
            double areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("area de x: " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de y: " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if(areax > areay) {
                Console.WriteLine("maior area: X");
            } else {
                Console.WriteLine("maior area: Y");
            }
        }
    }
}
