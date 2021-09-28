using System;
using System.Globalization;

namespace _7_classe_estoque_de_produtos {
    class Program {
        static void Main() {
            Produto p1 = new();
            
            Console.WriteLine("dados do produto:");
            Console.Write("nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());
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
            Console.WriteLine("mostrar os dados do produto usando p1 e ToString() override");
            Console.WriteLine("dados do produto: " + p1);
            //não é necessario o uso da função ToString pois é identificado
            //que o p1 ta concatenado em uma string
        }
    }
}
