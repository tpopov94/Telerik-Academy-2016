namespace School
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using System.Text;

    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private ICollection<Course> coursesList;
        private readonly int uniqueNumber;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.coursesList = new List<Course>();
            this.uniqueNumber = ++School.UniqueNumber;
            //this.UniqueNumber = uniqueNumber;
        }
        

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("First name must be at least 2 symbols long");
                }
                this.firstName = value;
            }
        }

        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Last name must be at least 2 symbols long");
                }
                this.lastName = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
        }

        public ICollection<Course> CoursesList
        {
            get
            {
                return this.coursesList;
            }
        }

        public void SignCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            this.coursesList.Add(course);
        }

        public void UnsignCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            this.coursesList.Remove(course);
        }

        /*  public override string ToString()
          {
              var sb = new StringBuilder();
              sb.AppendLine(string.Format("Full name: {0} {1}", this.FirstName, this.LastName));
              sb.AppendLine(string.Format("ID: {0}", this.uniqueNumber));

              foreach (var course in coursesList)
              {
                  sb.AppendLine(course.Title);
              }

              return sb.ToString();
          }*/
    }
}
