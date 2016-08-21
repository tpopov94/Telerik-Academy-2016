using System.Collections.Generic;

namespace School
{
    public class School
    {
        private List<Classes> classes;

        public School(params Classes[] classes)
        {
            this.Classes = new List<Classes>();
            this.Classes.AddRange(Classes);
        }

        public List<Classes> Classes
        {
            get { return this.classes; }
            private set { this.classes = value; }
        }

        public void AddClass(Classes newClass)
        {
            this.classes.Add(newClass);
        }

        public void Remove(Classes oldClass)
        {
            this.classes.Remove(oldClass);
        }
    }
}
