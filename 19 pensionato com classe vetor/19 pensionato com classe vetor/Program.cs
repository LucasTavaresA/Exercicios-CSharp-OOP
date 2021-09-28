using System;

namespace _19_pensionato_com_classe_vetor {
    class Program {
        static void Main() {
            Apartamento[] Apartamento = new Apartamento[10];

            Console.Write("quantos quartos serão alugados: ");
            int aluga = int.Parse(Console.ReadLine());
            for(int i = 1; i <= aluga; i++) {
                Console.WriteLine("aluguel #" + i + ":");
                
                Console.Write("nome: ");
                string nome = Console.ReadLine();

                Console.Write("email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                Apartamento[quarto] = new(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("quartos ocupados:");
            for(int i = 0; i < 10; i++) {
                if(Apartamento[i] == null) {
                    continue;
                } else {
                    Console.WriteLine(i + ": " + Apartamento[i]);
                }
            }
        }
    }
}
