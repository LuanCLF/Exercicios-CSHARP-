using Listas_InserirEditar.domain;

internal class Program
{
    private static void Main()
    {
        Console.Write("How many employees will be registered? ");
        int amount = int.Parse(Console.ReadLine()!);

        List<Functionary> functionaries = [];

        for (int i = 0; i < amount; i++)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine()!);


            functionaries.Add(new Functionary(id, name, salary));
        }

        Increase(ref functionaries);
    }

    protected static void Increase(ref List<Functionary> functionaries)
    {
        Console.Write("Enter the employee id that will have salary increase: ");
        int id = int.Parse(Console.ReadLine()!);

        Functionary? theChose = functionaries.Find(x => x.Id == id);

        if (theChose != null)
        {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine()!);

            theChose.Increase(percentage);
        }
        else
        {
            Console.WriteLine("The ID does not exist");
        }

        Console.WriteLine("Updated list of employees:");

        foreach (Functionary functionary in functionaries)
        {
            Console.WriteLine(functionary);
        }

    }


}