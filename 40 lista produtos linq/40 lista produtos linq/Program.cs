using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _40_lista_produtos_linq.Entities;

namespace _40_lista_produtos_linq
{
    class Program
    {
        static void Main()
        {
            List<Product> Products = new();
            using StreamReader sr = File.OpenText(@"c:\temp\temp.csv");
            while(!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');
                string name = line[0];
                double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                Products.Add(new(name, price));
            }
            double media = Products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + media.ToString("F2", CultureInfo.InvariantCulture));
            var names = Products.Where(p => p.Price < media)
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name);
            foreach(string line in names)
            {
                Console.WriteLine(line);
            }
        }
    }
}
