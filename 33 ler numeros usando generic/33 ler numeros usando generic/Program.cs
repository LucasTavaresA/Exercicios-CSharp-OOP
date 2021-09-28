using _33_ler_numeros_usando_generic.Services;
using System;

namespace _33_ler_numeros_usando_generic
{
    class Program
    {
        static void Main()
        {
            PrintService<int> printService = new();

            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());
            for(int i = 0; i < values; i++)
            {
                int n = int.Parse(Console.ReadLine());
                printService.AddValue(n);
            }
            printService.Print();
            Console.Write("First: " + printService.First());
        }
    }
}
