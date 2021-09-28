using System.Globalization;
using System;

namespace _34_lista_produtos_com_generic.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product)) throw new ArgumentException("Argument is not a Product");
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
