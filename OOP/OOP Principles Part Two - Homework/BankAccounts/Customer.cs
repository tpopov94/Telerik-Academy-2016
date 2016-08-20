namespace BankAccounts
{
    using System;

    public abstract class Customer
    {
        private string name;
        private long iDNumber;

        public Customer(string name, long iDNumber)
        {
            this.Name = name;
            this.IDNumber = iDNumber;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("There cannot be customer account without an ID Name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public long IDNumber
        {
            get { return this.iDNumber; }
            protected set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Customer ID Number must be a positive number bigger than 0");
                }
                else
                {
                    this.iDNumber = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} \r\nID Number: {1}", this.Name, this.IDNumber);
        }
    }
}