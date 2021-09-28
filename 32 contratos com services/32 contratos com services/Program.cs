using _32_contratos_com_services.Entities;
using _32_contratos_com_services.Services;
using System;
using System.Globalization;

namespace _32_contratos_com_services
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract Contract = new(number, date, value);
            ContractService ContractService = new(new PaypalService());
            ContractService.ProcessContract(Contract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach(Installment installment in Contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
