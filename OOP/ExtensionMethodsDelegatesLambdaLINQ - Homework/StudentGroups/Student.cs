namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student // Task 9
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        //Constructors
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, string fN, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        // Properties

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("The name must be at least one symbol long");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("The name must be at least one symbol long");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get { return this.fN; }
            private set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("The student faculty number cannot be a negative number !!");
                }
                else
                {
                    this.fN = value;
                }
            }
        }

        public string Tel
        {
            get { return this.tel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The telephone cannot be null or empty !!");
                }
                else
                {
                    this.tel = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The E-mail cannot be null or empty !!");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            private set 
            { 
                this.marks = value; 
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Group number cannot be a negative number");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        // Methods

        public override string ToString()
        {
            var marks = this.marks
                .Where(m => m > 1);
            string allMarks = string.Empty;
            foreach (var mark in marks)
            {
                allMarks += mark + " ";
            }

            return string.Format("Student name: {0} {1} - Faculty Number: {2} Group: {6}\n\r" + 
            "Telephone: {3}, E-mail: {4}\r\n" +
            "Marks: {5}", this.firstName, this.lastName, this.fN, this.tel, this.email, allMarks, this.groupNumber);
        }
    }
}
