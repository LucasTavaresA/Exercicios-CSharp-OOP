using System;
using System.Globalization;

namespace _12_circ_e_vol_de_um_raio_usando_classe {
    class Calculadora {
        public static readonly double Pi = 3.14;
        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
