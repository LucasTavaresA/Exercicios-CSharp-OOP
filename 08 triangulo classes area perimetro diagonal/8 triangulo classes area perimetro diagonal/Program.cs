using System;
using System.Globalization;

namespace _8_triangulo_classes_area_perimetro_diagonal {
    class Program {
        static void Main() {
            Retangulo x = new();

            Console.WriteLine("largura e altura do triangulo:");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("area = " 
            + x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("perimetro = " 
            + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("diagonal = " 
            + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
