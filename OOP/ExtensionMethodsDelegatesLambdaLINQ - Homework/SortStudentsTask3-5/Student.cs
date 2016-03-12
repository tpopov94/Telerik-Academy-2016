using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudentsTask3_5
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int mark;
        private int age;

        //Constructors

        public Student()
        {

        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Properties

        public string FirstName
        {
            get { return this.firstName; }
            set
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
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("The name must be at least one symbol long");
                }
                this.lastName = value;
            }
        }

        public int Mark
        {
            get { return this.mark; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The mark cannot be a negative number!!");
                }
                else
                {
                    this.mark = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 180)
                {
                    throw new ArgumentException("Student age must be between 0 and 180");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        //Methods 

        //public IEnumerable<Student> OrderByFirstNameBeforeLast(Student[] arrayOfStudents) // Task 3
        //{
        //    var sorted =
        //       from st in arrayOfStudents
        //       where st.FirstName.CompareTo(st.LastName) < 0
        //       select st;

        //    return sorted;
        //}
    }
}
