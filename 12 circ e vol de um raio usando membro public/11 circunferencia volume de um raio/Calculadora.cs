using System;
using System.Globalization;

namespace _12_circ_e_vol_de_um_raio_usando_classe {
    class Calculadora {
        public readonly double Pi = 3.14;
        public double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        public double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
