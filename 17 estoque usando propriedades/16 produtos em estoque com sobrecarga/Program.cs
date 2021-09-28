using System;
using System.Globalization;

namespace _7_classe_estoque_de_produtos {
    class Program {
        static void Main() {
            Console.WriteLine("dados do produto:");
            Console.Write("nome: ");
            string nome = Console.ReadLine();
            Console.Write("preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p1 = new(nome, preco, quantidade);

            p1.DadosDoProduto();
            Console.WriteLine();

            //mudar o nome do produto com propriedade nome
            //get
            p1.Nome = Console.ReadLine();
            //set
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);
        }
    }
}
