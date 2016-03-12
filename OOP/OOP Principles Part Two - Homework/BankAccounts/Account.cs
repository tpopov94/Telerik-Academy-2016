namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        //private string customer;
        private Customer customer;
        private decimal bankBalance;
        private decimal interestRate;

        // Constructors

        public Account(Customer customer, decimal bankBalance, decimal interestRate)
        {
            this.Customer = customer;
            this.BankBalance = bankBalance;
            this.InterestRate = interestRate;
        }

        // Properties

       // public string Customer { get; set; }

        public Customer Customer { get; private set; }

        public decimal BankBalance
        {
            get { return this.bankBalance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bank Balance must be at least 0 !");
                }
                else
                {
                    this.bankBalance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interest rate must be a positive number > 0");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        // Methods

        public abstract decimal InterestAmount(int months);

        public override string ToString()
        {
            return string.Format("{0} owner: {1}\n\rBalance: {2:C}\n\rInterest Rate: {3}%",GetType().Name, this.Customer, this.BankBalance, this.InterestRate);
        }
    }
}
