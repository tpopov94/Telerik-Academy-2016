namespace BankAccounts
{
    using System;

    public class Individual : Customer
    {
        private DateTime birthDate;
        private Gender gender;

        public Individual(string name, long iDNumber, DateTime birthDate, Gender gender)
            : base(name, iDNumber)
        {
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            private set
            {
                this.birthDate = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            private set
            {
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +"\n\r" + string.Format("Birth Date: {0:dd,MM,yyyy}\n\rGender: {1}",this.BirthDate, this.Gender);
        }
    }
}
