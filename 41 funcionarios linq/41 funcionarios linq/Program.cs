using _41_funcionarios_linq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _41_funcionarios_linq
{
    class Program
    {
        static void Main()
        {
            List<Employee> Employees = new();

            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            using StreamReader sr = File.OpenText(@"c:\temp\temp.csv");
            while(!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(',');
                string name = s[0];
                string email = s[1];
                double salary = double.Parse(s[2], CultureInfo.InvariantCulture);
                Employees.Add(new(name, email, salary));
            }
            var emails = Employees.Where(obj => obj.Salary > limit)
                .OrderBy(obj => obj.Email)
                .Select(obj => obj.Email);

            var sum = Employees.Where(obj => obj.Name[0] == 'M')
                .Sum(obj => obj.Salary);

            Console.WriteLine("Email of people whose salary is more than " 
                + limit.ToString("F2", CultureInfo.InvariantCulture));
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " 
                + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
