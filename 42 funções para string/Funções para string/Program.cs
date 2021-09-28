using System;

namespace Funções_para_string {
    class Program {
        static void Main() {
            //funções para string//

            //string original
            string original = "abcde FGHIJ ABC abc DEFG ";
            Console.WriteLine("Original: -" + original + "-");

            //tudo maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine("ToUpper: -" + s1 + "-");

            //tudo minusculo
            string s2 = original.ToLower();
            Console.WriteLine("ToLower: -" + s2 + "-");

            //apaga espaços em branco antes e depois
            string s3 = original.Trim();
            Console.WriteLine("Trim: -" + s3 + "-");

            //diz a posição do primeiro "bc" na string
            int n1 = original.IndexOf("bc");
            Console.WriteLine("IndexOf('bc'): " + n1);

            //diz a posição do ultimo "bc" na string
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf('bc'): " + n2);

            //recorta toda a string a partir da 3 caracter
            string s4 = original.Substring(3);
            Console.WriteLine("Substring(3): -" + s4 + "-");

            //recorta 5 caracteres da string a partir do 3 caracter
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");

            //troca todos os caracter "a" por "x"
            string s6 = original.Replace('a', 'x');
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");

            //troca todas as string "abc por "xy"
            string s7 = original.Replace("abc", "xy");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");

            //retorna true se o conteudo da variavel é nulo ou se esta vazia ""
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("IsNullOrEmpty: " + b1);

            //retorna true se o conteudo da variavel é nulo ou espaços em branco "    "
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
