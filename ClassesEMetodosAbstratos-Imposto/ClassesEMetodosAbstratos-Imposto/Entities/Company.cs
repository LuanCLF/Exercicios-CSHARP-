﻿namespace ClassesEMetodosAbstratos_Imposto.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees <= 10) return AnualIncome * 0.16;
            else return AnualIncome * 0.14;
        }
    }
}
