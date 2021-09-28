using System;
using System.Globalization;

namespace _12_circ_e_vol_de_um_raio_usando_classe {
    class Program {
        static void Main() {
            Calculadora calc = new();
            Console.Write("valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
