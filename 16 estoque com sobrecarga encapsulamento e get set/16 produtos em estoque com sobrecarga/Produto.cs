using System;
using System.Globalization;

namespace _7_classe_estoque_de_produtos {
    class Produto {
        //foi feito o encapsulamento manual
        //quando o atributo é private usa-se underline e padrão camelCase
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto() {
            _quantidade = 0;
        }
        public Produto(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            _quantidade = quantidade;
        }
        public string GetNome() {
            return _nome; //metodo get pra imprimir o nome
        }
        public void SetNome(string nome) {
            _nome = nome; //metodo set pra mudar o nome
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos() {
            _quantidade += int.Parse(Console.ReadLine());
        }
        public void RemoverProdutos() {
            _quantidade -= int.Parse(Console.ReadLine());
        }
        public void DadosDoProduto() {
            Console.WriteLine("dados do produto: "
            + _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
        public override string ToString() {
            return
            _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            //outra forma de usar a string p1
            //p1.ToString() é o return acima
        }
    }
}
