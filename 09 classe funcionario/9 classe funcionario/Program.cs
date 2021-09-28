using System;
using System.Globalization;

namespace _9_classe_funcionario {
    class Program {
        static void Main() {
            Funcionario f = new();

            Console.Write("nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("funcionario: " + f.Nome 
            + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("porcentagem do aumento: ");
            f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("dados atualizados: " + f.Nome + ", $ " 
            + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
