using System;
using System.Globalization;

namespace _2_triangulo {
    class Program {
        static void Main() {
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

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("area de x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY) {
                Console.WriteLine("maior area: X");
            } else {
                Console.WriteLine("maior area: Y");
            }
        }
    }
}
