namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student : Person, IComment
    {
        private long studentID;

        private List<string> commentList = new List<string>(); // For IComment

        //Constructors

        public Student(string firstName, string lastName, long studentID)
            : base(firstName, lastName)
        {
            this.StudentID = studentID;
        }

        // Properties

        public long StudentID
        {
            get { return this.studentID; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student ID must a positive number !=0 !!");
                }
                this.studentID = value;
            }
        }

        // Methods

        public override string ToString()
        {
            return string.Format("Student: {0} {1} ID: {2}", this.FirstName, this.LastName, this.studentID);
        }

        public void AddComment(string comment)
        {
            commentList.Add(comment);
        }

        public string ShowComments()
        {
            var result =string.Empty;
            for (int i = 0; i < commentList.Count; i++)
            {
                result +=commentList[i]  + "\n\r";
            }
            return result;
        }
    }
}
