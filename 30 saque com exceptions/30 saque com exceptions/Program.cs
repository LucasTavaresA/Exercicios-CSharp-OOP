using System;
using System.Globalization;
using _30_saque_com_exceptions.Entities.Exceptions;
using _30_saque_com_exceptions.Entities;

namespace _30_saque_com_exceptions
{
    class Program
    {
        static void Main()
        {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(amount);
                Console.Write("New balance: " 
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(WithdrawException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
