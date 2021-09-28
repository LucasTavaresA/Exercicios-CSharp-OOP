using _30_saque_com_exceptions.Entities.Exceptions;

namespace _30_saque_com_exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account(int number, string holder, double initialBalance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = initialBalance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds the withdraw limit!");
            }
            if(amount > Balance)
            {
                throw new WithdrawException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
