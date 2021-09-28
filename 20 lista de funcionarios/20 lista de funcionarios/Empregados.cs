using System.Globalization;

namespace _20_lista_de_funcionarios {
    class Empregados {
        //autoimplementadas
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        //construtores
        public Empregados(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void Aumento(double porcentagem) {
            Salario += (Salario * porcentagem) / 100;
        }
        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
