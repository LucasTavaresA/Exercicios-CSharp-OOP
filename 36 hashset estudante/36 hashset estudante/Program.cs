using System;
using System.Collections.Generic;
using System.IO;
using _36_hashset_estudante.Entities;

namespace _36_hashset_estudante
{
    class Program
    {
        static void Main()
        {
            HashSet<Estudante> Estudantes = new();

            Console.Write("how many estudantes for course A? ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Estudantes.Add( new(id));
            }
            Console.Write("how many estudantes for course B? ");
            int b = int.Parse(Console.ReadLine());
            for(int i = 0; i < b; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Estudantes.Add(new(id));
            }
            Console.Write("how many estudantes for course C? ");
            int c = int.Parse(Console.ReadLine());
            for(int i = 0; i < c; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Estudantes.Add(new(id));
            }
            Console.WriteLine("Total estudants: " + Estudantes.Count);
        }
    }
}
