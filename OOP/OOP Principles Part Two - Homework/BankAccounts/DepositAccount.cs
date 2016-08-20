namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal bankBalance, decimal interestRate)
            : base(customer, bankBalance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0;
            if (this.BankBalance < 1000)
            {
                Console.WriteLine("Bank balance must be larger than {0:C} to count Interest Amount. Your balance is: {1:C}", 1000, this.BankBalance);
            }
            else
            {
                interestAmount = (this.InterestRate/100 * months);
            }
            return interestAmount;
        }

        public void AddMoney(decimal amount)
        {
            this.BankBalance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (this.BankBalance < amount)
            {
                Console.WriteLine("Not enough money to withdraw. Your balance is: {0:C}", this.BankBalance);
            }
            else
            {
                this.BankBalance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
