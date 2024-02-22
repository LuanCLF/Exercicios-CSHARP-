using TratamentoDeExcecoes_Banco.Entities;
using TratamentoDeExcecoes_Banco.Entities.Exception;
using System.Globalization;

namespace TratamentoDeExcecoes_Banco
{
    internal class Program
    {
        static void Main()
        {

            try
            {
                Console.WriteLine("Enter the account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine()!);

                Console.Write("Holder: ");
                string holder = Console.ReadLine()!;

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine()!);
                
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine()!);

                Account user = new Account(number, holder, balance, withdrawLimit);



                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine()!);

                user.Withdraw(withdraw);

                Console.WriteLine($"New balance: {user.Balance:F2}");
            } catch (DomainExpeption ex) 
            {
                Console.WriteLine(ex.Message);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
