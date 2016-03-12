namespace BankAccounts
{
    using System;

    public class LoanAccount : Account, IDepositable
    {

        // Constructors

        public LoanAccount(Customer customer, decimal bankBalance, decimal interestRate)
            : base(customer, bankBalance, interestRate)
        {

        }

        // Methods

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00M;

            if (this.Customer is Individual && months >= 2)
            {
                interestAmount = this.InterestRate/100 * (months - 2);
            }
            else if (this.Customer is Company && months >= 3)
            {
                interestAmount = this.InterestRate/100 * (months - 2);
            }
            return interestAmount;
        }

        // Correct me if I am wrong but in loan accounts you have to return money to the bank
        // so when you are adding money to the Bank Amount of the deposit is subtracted from the initial balance
        public void AddMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit a negative number !!");
            }
            if (this.BankBalance < amount)
            {
                Console.WriteLine("You have paid your loan !!");
                this.BankBalance = 0;
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
