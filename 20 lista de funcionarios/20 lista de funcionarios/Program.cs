using System;
using System.Collections.Generic;
using System.Globalization;

namespace _20_lista_de_funcionarios {
    class Program {
        static void Main() {

            Console.Write("adicionara quantos empregados? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregados> Emprega = new();

            Console.WriteLine();
            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Emprega.Add(new(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("id a receber aumento: ");
            int searchId = int.Parse(Console.ReadLine());

            Empregados emp = Emprega.Find(x => x.Id == searchId);
            if(emp != null) {
                Console.WriteLine("porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Aumento(porcentagem);
            } else {
                Console.WriteLine("esse Id não existe!");
            }
            Console.WriteLine();

            Console.WriteLine("lista de funcionarios atualizada:");
            foreach(Empregados obj in Emprega) {
                Console.WriteLine(obj);
            }

        }
    }
}
