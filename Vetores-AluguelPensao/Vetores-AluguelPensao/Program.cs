using Vetores_AluguelPensao.domain;

internal class Program
{
    private static void Main()
    {

        Tenant[] apartments = new Tenant[10];

        Console.Write("Quantos quartos serão alugados? ");
        int rentals = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < rentals; i++)
        {
            Console.Write("Qual seu nome? ");
            string name = Console.ReadLine()!;

            Console.Write("Qual seu email? ");
            string email = Console.ReadLine()!;

            Console.Write("Qual o quarto? ");
            int room = CheckRoom(apartments);
            int rent = i + 1;

            apartments[room] = new Tenant(rent, name, email, room);
           

            Console.WriteLine($"Aluguel #{rent}");
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Quarto: {room}");

        }


       for(int i = 0; i < apartments.Length;i++)
        {
            if (apartments[i] != null) Console.WriteLine(apartments[i]);
        }


    }

    private static int CheckRoom(Tenant[] apartments)


    {
        int room = int.Parse(Console.ReadLine()!);

        if (apartments[room] == null) return room; 
       
        while (apartments[room] != null)
        {
            Console.Write("O quarto não está vago, informe outro: ");
            room = int.Parse(Console.ReadLine()!);
          
        }
        
        return room;


    }
}