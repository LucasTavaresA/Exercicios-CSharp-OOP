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

            //isso só funciona com um construtor padrão na classe
            //ou como padrão se não haver construtores na classe
            Produto p2 = new();

            /*funciona mesmo se a classe estiver sem construtores implementados
              não funcionaria agora por causa dos atributos em private
            Produto p3 = new() {
                _nome = "TV",
                _preco = 500.00,
                _quantidade = 10
            };
            */
            
            //Console.WriteLine(p1._nome); n funciona _nome é private

            //vc pode obter o nome do produto usando o metodo get
            //é necessario um metodo get la na classe para imprimir o _nome
            Console.WriteLine(p1.GetNome()); //esse funciona

            //vc pode mudar o _nome usando o metodo set
            p1.SetNome(Console.ReadLine()); //esse funciona
            Console.WriteLine(p1.GetNome());

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
