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
            Console.Write("quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p1 = new(nome, preco, quantidade);

            p1.DadosDoProduto();
            Console.WriteLine();

            Console.Write("numero de produtos para adicionar: ");
            p1.AdicionarProdutos();
            p1.DadosDoProduto();
            Console.WriteLine();

            Console.Write("numero de produtos para remover: ");
            p1.RemoverProdutos();
            Console.WriteLine();
            p1.DadosDoProduto();

            Console.WriteLine();
            Console.WriteLine("mostrar os dados do produto usando ToString() override");
            Console.WriteLine("dados do produto: " + p1);
            //não é necessario o uso da função ToString pois é identificado
            //que o p1 esta em uma string console.writeline();
        }
    }
}
