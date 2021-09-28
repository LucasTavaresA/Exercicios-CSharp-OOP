using System;
using _24_post_com_lista_de_comentarios.Entities;

namespace _24_post_com_lista_de_comentarios
{
    class Program
    {
        static void Main()
        {
            Post p1 = new(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            Comment c1 = new("Have a nice trip");
            Comment c2 = new("Wow that's awesome!");
            p1.AddComent(c1);
            p1.AddComent(c2);

            Post p2 = new(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            Comment c3 = new("Good night");
            Comment c4 = new("May the Force be with you");
            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
