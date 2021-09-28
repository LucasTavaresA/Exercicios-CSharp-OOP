using System;
using System.Collections.Generic;

namespace _37_dictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> cookies = new();

            cookies["User"] = "Maria";
            cookies["email"] = "Maria@gmail.com";
            cookies["phone"] = "9934732847";
            cookies["phone"] = "3423343645";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            if(cookies.ContainsKey("Email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("no email");
            }
            Console.WriteLine("size: " + cookies.Count);

            Console.WriteLine("All cookies:");
            // pode colocar (var item in cookies)
            foreach(KeyValuePair<string, string> item in cookies) 
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
