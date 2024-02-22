using TratamentoDeExcecoes_Banco.Entities.Exception;



namespace TratamentoDeExcecoes_Banco.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string   Holder { get; private set; }

        public double Balance { get; private set; }
        public double WithdrawLimit  { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
            
            Deposit(balance);
        }

        public void Deposit(double deposit)
        {
            if (deposit <= 0) throw new DomainExpeption("Deposit error: The value must be greater than 0");

           Balance = deposit;
        }

        public void Withdraw(double withdraw)
        {

            if (withdraw <= 0) throw new DomainExpeption("Withdrawerror: The value must be greater than 0");

            if (withdraw > Balance) throw new DomainExpeption("Withdrawerror: There is not enough balance in the account");

            if (withdraw > WithdrawLimit) throw new DomainExpeption("Withdrawerror: The withdrawal amount is higher than the allowed limit");
        
            Balance -= withdraw;
        }
    }
}
