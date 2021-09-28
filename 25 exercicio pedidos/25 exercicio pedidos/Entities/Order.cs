using _25_exercicio_pedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _25_exercicio_pedidos.Entities
{
    class Order
    {
        public Client Client { get; set; }
        public OrderItem OrderItem { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orders { get; set; } = new();

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem order)
        {
            Orders.Add(order);
        }
        public void RemoveItem(OrderItem order)
        {
            Orders.Remove(order);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem Order in Orders)
            {
                sum += Order.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Orders)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
