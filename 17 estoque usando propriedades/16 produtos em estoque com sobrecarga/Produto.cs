using System;
using System.Globalization;

namespace _7_classe_estoque_de_produtos {
    class Produto {
        //ORDEM RECOMENDADA DE CLASSES//
        //ATRIBUTOS PRIVADOS//
        private string _nome;
        //PROPRIEDADES AUTOIMPLEMENTADAS//
        public double Preco { get; private set; } //com autoproperty
        public int Quantidade { get; private set; } 
        //CONSTRUTORES//
        public Produto() {
        }
        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }
        //PROPRIEDADES CUSTOMIZADAS//
        public string Nome { //propriedade nome no lugar de getnome() e setnome()
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value;  //esse if só muda o nome se for maior q um digito e não nulo 
                }
            }
        }
        /*
        //sem auto autoproperty
        public double Preco {
            get { return _preco; } 
        }
        public int Quantidade {
            get { return _quantidade; }
        }
        */
        //OUTROS METODOS//
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
            + _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
