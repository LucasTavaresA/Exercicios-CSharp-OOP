using _28_metodos_abstratos.Entities;
using _28_metodos_abstratos.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace _28_metodos_abstratos
{
    class Program
    {
        static void Main()
        {
            List<Shape> Shapes = new();

            Console.Write("Enter number of shapes: ");
            int amount = int.Parse(Console.ReadLine());
            for(int i = 1; i <= amount; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char form = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(form == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Rectangle(width, height, color));
                }
                else if(form == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape areas:");
            foreach(Shape Shape in Shapes)
            {
                Console.WriteLine(Shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
