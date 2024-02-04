

using Course.domain;

internal class Program
{
    private static void Main(string[] args)
    {



        Console.Write("Entre o número da conta: ");
        string number = Console.ReadLine()!;
        Console.Write("Entre o titular da conta: ");
        string name = Console.ReadLine()!;
        Console.Write("Haverá depósito inicial(s/n)? ");
        char response = char.Parse(Console.ReadLine()!);
    
        double initialDeposit = response == 's' ? double.Parse(Console.ReadLine()!) : 0.0;

      BankUser user = new BankUser(number, name, initialDeposit);

        Console.WriteLine("Dados da conta:");
        Console.WriteLine(user);

        Console.Write("Entre um valor para depósito: ");
        double depositValue = double.Parse(Console.ReadLine()!);
        user.Deposit(depositValue);

        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(user);

        Console.Write("Entre um valor para saque: ");
        double withdrawValue = double.Parse(Console.ReadLine()!);
        user.Withdraw(withdrawValue);

        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(user);


    }
}