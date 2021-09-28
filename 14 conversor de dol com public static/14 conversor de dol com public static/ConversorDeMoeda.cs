namespace _14_conversor_de_dol_com_public_static {
    class ConversorDeMoeda {
        public static double Iof = 6.0;
        public static double ValorReais(double cotacao, double dol) {
            double total = dol * cotacao;
            return total + total * Iof / 100.00;
        }
    }
}
