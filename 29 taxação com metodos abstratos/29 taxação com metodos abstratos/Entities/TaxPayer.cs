namespace _29_taxação_com_metodos_abstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
