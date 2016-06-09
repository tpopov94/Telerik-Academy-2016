namespace MobilePhoneProject
{
    using System;

    public class Call  // Task 8
    {
        private DateTime date;
        private string phoneNumber;
        private int duration;

        //Constructors

        public Call(DateTime date, string phoneNumber, int duration)
        {
            this.Date = date;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        // Properties

        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            private set
            {
                if (value.Length <= 13)
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("The phone number must be no longer than 13 characters eg. 0899445566/ +359899445566");
                }
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The duration of the phone cannot be a negative number !!");
                }
                else
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Date and time: {0:G}; Duration: {1} seconds;\nDialed number: {2}",
            this.date, this.duration, this.phoneNumber);
        }
    }
}
