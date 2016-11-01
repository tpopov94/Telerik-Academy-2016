using System.Data.Entity;

using StudentsSystem.Models;

namespace StudentsSystem.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext():
            base("StudentsDb")
        { 
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }
    }
}
