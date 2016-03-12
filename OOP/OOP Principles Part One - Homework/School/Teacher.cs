namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, IComment 
    {
        private List<Discipline> disciplinesList;

        private List<string> commentList = new List<string>(); // For IComment

        // Constructors

        public Teacher(string firstName, string lastName, List<Discipline> disciplinesList)
            :base(firstName,lastName)
        {
            this.DisciplineList = disciplinesList;
        }

        // Properties

        public List<Discipline> DisciplineList
        {
            get { return this.disciplinesList; }
            private set 
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Please give the teachers some work - give them a discipline !!!");
                }
                else
                {
                    this.disciplinesList = value;
                }
            }
        }

        //// Methods 

        public override string ToString()
        {
            return string.Format("Teacher: {0} {1} \r\nDisciplines: \r\n{2}", this.FirstName,this.LastName,string.Join("\r\n", this.DisciplineList));
        }
     
        public void AddComment(string comment)
        {
            commentList.Add(comment);
        }
    }
}
