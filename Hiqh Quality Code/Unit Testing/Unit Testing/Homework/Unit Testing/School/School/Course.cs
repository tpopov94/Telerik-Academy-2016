namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string title;
        private ICollection<Student> studentsList;

        public Course(string title)
        {
            this.Title = title;
            this.studentsList = new List<Student>();
        }

        // properties

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course title cannot be null or empty");
                }

                this.title = value;
            }
        }

        public ICollection<Student> StudentsList
        {
            get
            {
                return this.studentsList;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.StudentsList.Count >= 29)
            {
                throw new ArgumentOutOfRangeException("Students list cannot contain more than 29 students");
            }

            if (this.studentsList.Count < 29)
            {
                if (this.studentsList.Contains(student))
                {
                    throw new ApplicationException("The same student cannot be added more than once");
                }
                this.studentsList.Add(student);
            }
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            this.studentsList.Remove(student);
        }
    }
}
