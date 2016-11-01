namespace StudentsSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentsSystem.Data.StudentsDbContext";
        }
    
        protected override void Seed(StudentsDbContext context)
        {
            context.Students
                 .AddOrUpdate(s => s.Name,
                 new Student
                 {
                     Name = "Pesho e Pesho",
                     FacultyNumber = "0987654321"
                 });
        }
    }
}
