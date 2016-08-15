namespace School
{
    using System;


    public class School
    {
        private static int uniqueNumber = 9999;
        private string name;

        public School(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("School name cannot be null");
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("School name cannot be whitespace");
                }
                this.name = value;
            }
        }
        public static int UniqueNumber
        {
            get
            {
                return uniqueNumber;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Student number must be between 10000 and 99999");
                }
                uniqueNumber = value;
            }
        }
    }
}
