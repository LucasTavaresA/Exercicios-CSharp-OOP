using _31_locadora_com_interface_e_services.Entities;
using _31_locadora_com_interface_e_services.Services;
using System;
using System.Globalization;

namespace _31_locadora_com_interface_e_services
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new(start, finish, new Vehicle(model));

            RentalService rentalService = new(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
