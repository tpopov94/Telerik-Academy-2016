namespace BankAccounts
{
    using System;

    public class Company: Customer
    {
        private string companyManager;
        

        public Company(string name, long iDNumber,string companyManager)
            :base(name,iDNumber)
        {
            this.CompanyManager = companyManager;
        }
        
        public string CompanyManager
        {
            get { return this.companyManager; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("There cannot be company account without company magers name");
                }
                else
                {
                    this.companyManager = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\rComapany manager: " + this.CompanyManager;
        }
    }
}