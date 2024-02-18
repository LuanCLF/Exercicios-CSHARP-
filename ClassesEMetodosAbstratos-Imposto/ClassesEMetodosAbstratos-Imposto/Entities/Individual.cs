namespace ClassesEMetodosAbstratos_Imposto.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public Individual(string name, double anualIncome, double healthExpenditures): base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome < 20000) tax += AnualIncome * 0.15;
            else tax += AnualIncome * 0.25;

             tax -= HealthExpenditures * 0.5;

            return tax;
        }
    }
}
