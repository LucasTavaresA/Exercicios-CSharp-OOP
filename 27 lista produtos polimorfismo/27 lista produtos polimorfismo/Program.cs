using System;
using System.Collections.Generic;
using System.Globalization;
using _27_lista_produtos_polimorfismo.Entities;

namespace _27_lista_produtos_polimorfismo
{
    class Program
    {
        static void Main()
        {
            List<Product> Products = new();

            Console.Write("How many products: ");
            int cont = int.Parse(Console.ReadLine());
            for(int i = 1; i <= cont; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i): ");
                char pOrigin = char.Parse(Console.ReadLine()); 
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(pOrigin == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Products.Add(new ImportedProduct(name, price, customsFee));
                } else if(pOrigin == 'u')
                {
                    Console.Write("Manufacture date (dd/mm/yyyy): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Products.Add(new UsedProduct(name, price, manufactureDate));
                } else
                {
                    Products.Add(new(name, price));
                }            
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product Product in Products)
            {
                Console.WriteLine(Product.PriceTag());
            }
        }
    }
}
