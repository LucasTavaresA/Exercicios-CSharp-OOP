using System;

namespace _21_exercicio_matriz {
    class Program {
        static void Main() {
            string[] s = Console.ReadLine().Split(' ');
            int lin = int.Parse(s[0]);
            int col = int.Parse(s[1]);
            int[,] mat = new int[lin, col];

            for(int i = 0; i < lin; i++) {
                s = Console.ReadLine().Split(' ');
                for(int j = 0; j < col; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < lin; i++) {
                for(int j = 0; j < col; j++) {
                    if(mat[i, j] == n) {
                        Console.WriteLine("posicao " + i + "," + j + ":");
                        if(j > 0) {
                            Console.WriteLine("left: " + mat[i, j - 1]);
                        }
                        if(i > 0) {
                            Console.WriteLine("up: " + mat[i - 1, j]);
                        }
                        if(j < lin - 1) {
                            Console.WriteLine("right: " + mat[i, j + 1]);
                        }
                        if(i < col - 1) {
                            Console.WriteLine("down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
