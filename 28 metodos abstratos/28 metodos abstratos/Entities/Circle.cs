using _28_metodos_abstratos.Entities.Enums;
using System;

namespace _28_metodos_abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
