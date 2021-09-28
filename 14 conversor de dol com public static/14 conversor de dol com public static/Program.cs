using System;
using System.Globalization;

namespace _14_conversor_de_dol_com_public_static {
    class Program {
        static void Main() {
            Console.Write("cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantia em dolar? ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("valor em reais = " 
                + ConversorDeMoeda.ValorReais(cotacao, dol).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
