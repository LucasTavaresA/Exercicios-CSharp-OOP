using System;

namespace _1_funcao {
    class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Maior(n1, n2, n3));
        }

        static int Maior(int a, int b, int c) {
            int m;
            if(a > b && a > c) { 
                m = a; 
            } else if(b > a && b > c) {
                m = b;
            } else {
                m = c;
            }
            return m;
        }
    }
}
