using System;
using _38_extension_methods.Extensions;

namespace _38_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new(2021, 07, 26, 10, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
