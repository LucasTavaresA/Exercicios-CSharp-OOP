using System;
using System.Globalization;

namespace _2_triangulo {
    class Program {
        static void Main(string[] args) {
            double x1, x2, x3, y1, y2, y3, areax, areay, p;

            Console.WriteLine("x 1 2 3: ");
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("y 1 2 3");
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (x1 + x2 + x3) / 2;
            areax = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));

            p = (y1 + y2 + y3) / 2;
            areay = Math.Sqrt(p * (p - y1) * (p - y2) * (p - y3));

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
