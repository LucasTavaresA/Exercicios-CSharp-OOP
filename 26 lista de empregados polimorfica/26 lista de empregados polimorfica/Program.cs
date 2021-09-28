using _26_lista_de_empregados_polimorfica.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _26_lista_de_empregados_polimorfica
{
    class Program
    {
        static void Main()
        {
            List<Employee> Employees = new();

            Console.Write("enter number of employees: ");
            int nEmp = int.Parse(Console.ReadLine());
            for(int i = 1; i <= nEmp; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n): ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    Employees.Add(new(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in Employees)
            {
                Console.WriteLine(emp.Name
                    + " - $ "
                    + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
