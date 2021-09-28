using System;
using System.Collections.Generic;
using _34_lista_produtos_com_generic.Entities;
using _34_lista_produtos_com_generic.Services;
using System.Globalization;

namespace _34_lista_produtos_com_generic
{
    class Program
    {
        static void Main()
        {
            List<Product> list = new();

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                string name = s[0];
                double price = double.Parse(s[1], CultureInfo.InvariantCulture);

                list.Add(new(name, price));
            }

            CalculationService calculationService = new();

            Product max = calculationService.Max(list);
            Console.Write("MAX: ");
            Console.WriteLine(max);
        }
    }
}
