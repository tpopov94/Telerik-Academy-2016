namespace Person
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        // Constructors

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Properties

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Age must be between [0...200]");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        // Methods

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("{0} - age is not specified !", this.Name);
            }
            return string.Format("{0} - {1} !", this.Name, this.Age);
        }
    }
}
