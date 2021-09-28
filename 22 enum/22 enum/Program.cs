using _22_enum.Entities;
using _22_enum.Entities.Enums;
using System;

namespace _22_enum {
    class Program {
        static void Main() {
            Order order = new() {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
