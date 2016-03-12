namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        // Constructors

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        // Properties

        public int Grade
        {
            get { return this.grade; }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade must be in the range [2..6]");
                }
                this.grade = value;
            }
        }
    }
}
