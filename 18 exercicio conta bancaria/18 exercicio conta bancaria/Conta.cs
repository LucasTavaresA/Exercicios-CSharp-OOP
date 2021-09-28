using System;
using System.Globalization;

namespace _18_exercicio_conta_bancaria {
    class Conta {

        //privates
        private int _numero { get; set; }

        //autoimplementados
        public double Corrente { get; private set; }
        public string Titular { get; set; }

        //construtores
        public Conta(int numero, string titular) {
            _numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular) {
            _numero = numero;
            Titular = titular;
            Corrente = depositoInicial;
        }

        //outros metodos
        public void DadosConta() {
            Console.WriteLine(
            "Conta " + _numero 
            + ", Titular: " + Titular 
            + ", Saldo: $ " + Corrente.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
        public void Deposito(double deposito) {
            Corrente += deposito;
        }
        public void Saque(double saque) {
            Corrente -= saque + 5.0;
        }
    }
}
