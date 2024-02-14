using HerançaEPolimorfismo_Produtos.Entities;

internal class Program
{
    private static void Main()
    {
        Console.Write("Enter the number of products: ");
        int quantity = int.Parse(Console.ReadLine()!);

        Product[] products = new Product[quantity];

        for (int i = 1; i <= quantity; i++)
        {
            Console.WriteLine($"Product #{i} data:");

            Console.Write("Common, used or imported (c/u/i)? ");
            char productType = char.Parse(Console.ReadLine()!);

            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine()!);

            if (productType == 'i')
            {
                Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine()!);


                products[i - 1] = new ImportedProduct(name, price, customsFee); ;
            }

            if (productType == 'u')
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine()!);

                products[i - 1] = new UsedProduct(name, price, manufactureDate);
            }

            if (productType == 'c')
            {
                products[i - 1] = new Product(name, price);
            }
        }

        Console.WriteLine("PRICE TAGS:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}