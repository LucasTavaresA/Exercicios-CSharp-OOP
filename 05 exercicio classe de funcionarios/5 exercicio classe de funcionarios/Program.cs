using System;
using System.Globalization;

namespace _5_exercicio_classe_de_funcionarios {
    class Program {
        static void Main() {
            Funcionarios p1 = new();
            Funcionarios p2 = new();

            Console.WriteLine("dados do primeiro funcionario:");
            Console.Write("nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("salaro: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("dados do segundo funcionario:");
            Console.Write("nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("salaro: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("salario medio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
