namespace _9_classe_funcionario {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * porcentagem) / 100.0;
        }
    }
}
