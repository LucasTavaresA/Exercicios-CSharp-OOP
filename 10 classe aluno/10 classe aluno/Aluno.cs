using System;
using System.Globalization;

namespace _10_classe_aluno {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaF() {
            return Nota1 + Nota2 + Nota3;
        }
        public void Condicao() {
            if(NotaF() > 60.0) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
                double faltaram = Math.Abs(NotaF() - 60.0);
                Console.WriteLine("faltaram " 
                    + faltaram.ToString("F2", CultureInfo.InvariantCulture) 
                    + " pontos");
            }
        }
    }
}
