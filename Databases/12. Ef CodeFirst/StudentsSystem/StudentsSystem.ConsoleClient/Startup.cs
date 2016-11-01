using System;
using System.Data.Entity;
using System.Linq;

using StudentsSystem.Data;
using StudentsSystem.Data.Migrations;
using StudentsSystem.Models;

namespace StudentsSystem.ConsoleClient
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsDbContext, Configuration>());

            var db = new StudentsDbContext();

            var student = new Student
            {
                Name = "Pesho",
                FacultyNumber = "1234567890"
            };

            db.Students.Add(student);
           // db.SaveChanges();

            Console.WriteLine(db.Students.Count());
        }
    }
}
