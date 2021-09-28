using System;
using System.Globalization;

namespace _10_classe_aluno {
    class Program {
        static void Main() {
            Aluno a = new();

            Console.Write("nome: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("as tres notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("nota final = " + a.NotaF().ToString("F2", CultureInfo.InvariantCulture));
            a.Condicao();
        }
    }
}
