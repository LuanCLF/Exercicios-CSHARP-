using System;


namespace Course.domain;
public class BankUser
{

    public string Number { get; private set; } = null!;

    public string Name { get; private set; } = null!;
    public double Balance { get; private set; }

    public BankUser(string number, string name)
    {
        Number = number;
        Name = name;
    }

    public BankUser(string number, string name, double balance) : this(number, name)
    {

        Deposit(balance);
    }


    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            amount += 5;
            Balance -= amount;
        }
    }

    public override string ToString()
    {

        return $"Account {Number}, Holder: {Name}, Balance: R${Balance:F2}";


    }

}

