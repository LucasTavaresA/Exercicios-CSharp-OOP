namespace _29_taxação_com_metodos_abstratos.Entities
{
    class Company : TaxPayer
    {
        public int NEmployees { get; set; }
        public Company(string name, double anualIncome, int nEmployees) : base(name, anualIncome)
        {
            NEmployees = nEmployees;
        }
        public override double Tax()
        {
            if(NEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
