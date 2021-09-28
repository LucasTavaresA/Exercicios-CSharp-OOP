using System;
using System.Globalization;

namespace _7_classe_estoque_de_produtos {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos() {
            Quantidade += int.Parse(Console.ReadLine());
        }

        public void RemoverProdutos() {
            Quantidade -= int.Parse(Console.ReadLine());
        }

        public void DadosDoProduto() {
            Console.WriteLine("dados do produto: " 
            + Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", " 
            + Quantidade 
            + " unidades, Total: $ " 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }

        public override string ToString() {
            return 
            Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " 
            + Quantidade 
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            //outra forma de usar a string p1
            //p1.ToString() é o return acima
        }
    }
}
