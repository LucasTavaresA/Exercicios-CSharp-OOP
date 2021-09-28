using System;

namespace _4_classes_pessoas {
    class Program {
        static void Main() {
            Pessoa p1 = new();
            Pessoa p2 = new();

            Console.WriteLine("dados da primeira pessoa:");
            Console.Write("nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("dados da segunda pessoa:");
            Console.Write("nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade) {
                Console.WriteLine("pessoa mais velha: " + p1.Nome);
            } else {
                Console.WriteLine("pessoa mais velha: " + p2.Nome);
            }
        }
    }
}
