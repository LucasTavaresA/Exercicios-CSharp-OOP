﻿using System.Globalization;

namespace _25_exercicio_pedidos.Entities
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal() {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
