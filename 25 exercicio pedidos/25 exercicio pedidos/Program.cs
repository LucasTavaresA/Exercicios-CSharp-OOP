using System;
using System.Globalization;
using _25_exercicio_pedidos.Entities;
using _25_exercicio_pedidos.Entities.Enums;

namespace _25_exercicio_pedidos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.Write("status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client Client = new(name, email, birthDate);
            Order order = new(Client, DateTime.Now, status);

            Console.Write("how many items to order: ");
            int orders = int.Parse(Console.ReadLine());
            for(int i = 1; i <= orders; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product Product = new(prodName, price);
                OrderItem orderItem = new(Product, quantity, price);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}
