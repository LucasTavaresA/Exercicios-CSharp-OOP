using System;
using System.Globalization;

namespace _18_exercicio_conta_bancaria {
    class Program {
        static void Main() {
            Conta Conta;
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n)? ");
            char depositara = char.Parse(Console.ReadLine());
            if(depositara == 's' || depositara == 'S') {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new(numero, titular, depositoInicial);
            } else {
                Conta = new(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("dados da conta: ");
            Conta.DadosConta();

            Console.Write("entre um valor para deposito: ");
            Conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("dados atualizados:");
            Conta.DadosConta();

            Console.Write("entre um valor para saque: ");
            Conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("dados atualizados:");
            Conta.DadosConta();
        }
    }
}
