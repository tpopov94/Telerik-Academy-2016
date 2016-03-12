namespace School
{
    using System;
    using System.Collections.Generic;

    public class Classes
    {
        private List<Student> pupilsInClass;
        private List<Teacher> teachersInClass;
        private string classID;

        // Constructors

        public Classes(List<Teacher> teachersInClass, List<Student> pupilsInClass, string classID)
        {
            this.TeachersInClass = teachersInClass;
            this.PupilsInClass = pupilsInClass;
            this.ClassID = classID;
        }

        // Properties

        public List<Teacher> TeachersInClass
        {
            get { return this.teachersInClass; }
            private set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("This school class must have at least one teacher!!!");
                }
                else
                {
                    this.teachersInClass = value;
                }
            }
        }

        public List<Student> PupilsInClass
        {
            get { return this.pupilsInClass; }
            private set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("This school class must have at least one student !!!");
                }
                else
                {
                    this.pupilsInClass = value;
                }
            }
        }

        public string ClassID
        {
            get { return this.classID; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class ID cannot be null or empty");
                }
                else
                {
                    this.classID = value;
                }
            }
        }

        // Methods

    }
}
