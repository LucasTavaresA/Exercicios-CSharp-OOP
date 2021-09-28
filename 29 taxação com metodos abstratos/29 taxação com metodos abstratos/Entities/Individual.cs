namespace _29_taxação_com_metodos_abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExp { get; set; }
        public Individual(string name, double anualIncome, double healthExp) : base(name, anualIncome)
        {
            HealthExp = healthExp;
        }
        public override double Tax()
        {
            if(AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExp * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExp * 0.5;
            }
        }
    }
}
