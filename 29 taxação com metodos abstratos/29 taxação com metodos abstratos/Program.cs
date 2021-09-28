using _29_taxação_com_metodos_abstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _29_taxação_com_metodos_abstratos
{
    class Program
    {
        static void Main()
        {
            List<TaxPayer> TaxPayers = new();

            Console.Write("Enter number of taxpayers: ");
            int amount = int.Parse(Console.ReadLine());
            for(int i = 1; i <= amount; i++)
            {
                Console.WriteLine("Taxpayer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    TaxPayers.Add(new Individual(name, anualIncome, healthExp));
                }
                else if (type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income:: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());
                    TaxPayers.Add(new Company(name, anualIncome, nEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxes paid:");
            double totalTax = 0;
            foreach(TaxPayer taxPayer in TaxPayers)
            {
                Console.WriteLine(taxPayer.Name
                    + ": $ "
                    + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("Total tax: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
