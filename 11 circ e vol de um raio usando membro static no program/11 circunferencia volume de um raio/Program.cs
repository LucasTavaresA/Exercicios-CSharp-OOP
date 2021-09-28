using System;
using System.Globalization;

namespace _11_circunferencia_volume_de_um_raio {
    class Program {
        static readonly double Pi = 3.14; 
        static void Main() {
            Console.Write("valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
