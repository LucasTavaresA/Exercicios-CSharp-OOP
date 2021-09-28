namespace _19_pensionato_com_classe_vetor {
    class Apartamento {
        //autoimplementadas
        public string Nome { get; set; }
        public string Email { get; set; }
        //construtores
        public Apartamento(string nome, string email) {
            Nome = nome;
            Email = email;
        }
        public override string ToString() {
            return Nome
                + ", "
                + Email;
        }
    }
}
