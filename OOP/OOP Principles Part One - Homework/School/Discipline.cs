namespace School
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;
        private DisciplinesList disciplines;

        private List<string> commentList = new List<string>(); // For IComment

        //public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises) // Without enumeration
        //{
        //    this.DisciplineName=disciplineName;
        //    this.NumberOfLectures = numberOfLectures;
        //    this.NumberOfExercises = numberOfExercises;
        //}

        public Discipline(DisciplinesList disciplines , int numberOfLectures, int numberOfExercises) // With enumeration
        {
            this.Disciplines = disciplines;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string DisciplineName
        {
            get { return this.disciplineName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Disciplines cannot be null or empty");
                }
                else
                {
                    this.disciplineName = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Each discipline must have at least one lecture !!");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Each discipline must have at least one exercise !!");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }

        public DisciplinesList Disciplines
        {
            get { return this.disciplines; }
            private set {this.disciplines=value;}
        }

        public override string ToString()
        {
            return string.Format("Discipline: {0} - Number of lectures {1} - Exercises: {2}", this.Disciplines, this.NumberOfLectures,this.NumberOfExercises);
        }

        public void AddComment(string comment)
        {
            commentList.Add(comment);
        }
    }
}
