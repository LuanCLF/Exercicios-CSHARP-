using ClassesEMetodosAbstratos_Imposto.Entities;
using System.Globalization;

namespace ClassesEMetodosAbstratos_Imposto
{
    internal class Program
    {
        static void Main()
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers =int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine()!);

                Console.Write("Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine()!);

                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine()!);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditure));
                }

                if(type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine()!);

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double totalTaxes = 0.0;
            Console.WriteLine("TAXES PAID:");

            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: R${taxPayer.Tax():F2}");

                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine($"TOTAL TAXES: R${totalTaxes:F2}");
        }
    }
}
