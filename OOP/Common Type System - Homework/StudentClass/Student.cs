namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long socialSecurityNumber;
        private string address;
        private string phoneNumber;
        private string email;
        private int course;
        private University university;
        private Faculties faculty;
        private Specialities speciality;

        // Constructors

        public Student(string firstName, string middleName, string lastName, long socialSecurityNumber, string address,
            string phoneNumber, string email, int course, University university, Faculties faculty, Specialities speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        // Properties

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be null or empty");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public long SocialSecurityNumber
        {
            get { return this.socialSecurityNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Social Security Number cannot be a negative number or zero !!");
                }
                else
                {
                    this.socialSecurityNumber = value;
                }
            }
        }

        public string Address
        {
            get { return this.address; }
            private set { this.address = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            private set { this.phoneNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            private set { this.email = value; }
        }

        public int Course
        {
            get { return this.course; }
            private set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException("Course must be a number between 1-5");
                }
                else
                {
                    this.course = value;
                }
            }
        }

        public University University
        {
            get { return this.university; }
            private set { this.university = value; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
            private set { this.faculty = value; }
        }

        public Specialities Speciality
        {
            get { return this.speciality; }
            private set { this.speciality = value; }
        }

        // Methods

        // Task 1

        public override string ToString()
        {
            var text = new StringBuilder();

            text.AppendFormat("Student Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            text.AppendLine("\n\rSocial Security Number: " + this.SocialSecurityNumber);
            text.AppendLine("Address: " + this.Address);
            text.AppendLine("Mobile Phone: " + this.PhoneNumber);
            text.AppendLine("Email: " + this.Email);
            text.AppendLine("Course: " + this.Course);
            text.AppendLine("Speciality: " + this.Speciality);
            text.AppendLine("University: " + this.University);
            text.AppendLine("Faculty: " + this.Faculty);

            return text.ToString();
        }

        public override int GetHashCode()
        {
            return this.Address.GetHashCode() ^ this.Course.GetHashCode() * 12;
        }

        public override bool Equals(object obj)
        {
            var equalStudent = obj as Student;

            if (equalStudent == null)
            {
                return false;
            }
            if (this.FirstName != equalStudent.FirstName)
            {
                return false;
            }
            if (this.MiddleName != equalStudent.MiddleName)
            {
                return false;
            }
            if (this.LastName != equalStudent.LastName)
            {
                return false;
            }
            if (this.SocialSecurityNumber != equalStudent.SocialSecurityNumber)
            {
                return false;
            }
            if (this.Address != equalStudent.Address)
            {
                return false;
            }
            if (this.PhoneNumber != equalStudent.PhoneNumber)
            {
                return false;
            }
            if (this.Email != equalStudent.Email)
            {
                return false;
            }
            if (this.Course != equalStudent.Course)
            {
                return false;
            }
            if (this.University != equalStudent.University)
            {
                return false;
            }
            if (this.Faculty != equalStudent.Faculty)
            {
                return false;
            }
            if (this.Speciality != equalStudent.Speciality)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }


        // Task 2
        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.Address, this.PhoneNumber,
            this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        // Task 3


        public int CompareTo(object obj)
        {
            var otherStudent = obj as Student;

            string studentFullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (studentFullName.CompareTo(otherFullName) < 0)
            {
                return -1;
            }
            if (studentFullName.CompareTo(otherFullName) > 0)
            {
                return 1;
            }
            if (studentFullName.CompareTo(otherFullName) == 0)
            {
                if (this.SocialSecurityNumber < otherStudent.SocialSecurityNumber)
                {
                    return -1;
                }
                if (this.SocialSecurityNumber > otherStudent.SocialSecurityNumber)
                {
                    return 1;
                }
                if (this.SocialSecurityNumber == otherStudent.SocialSecurityNumber)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
