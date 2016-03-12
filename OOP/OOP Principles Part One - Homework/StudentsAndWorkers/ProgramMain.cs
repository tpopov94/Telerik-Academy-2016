/*
 Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. 
 Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. 
 Define the proper constructors and properties for this hierarchy.
 Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
 Initialize a list of 10 workers and sort them by money per hour in descending order.
 Merge the lists and sort them by first name and last name.
*/
namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramMain
    {
        static void Main()
        {
            // Sort Students by Grade

            var listOfStudents = new List<Student>
            {
                new Student("Pesho","Stamatov",3),
                new Student("Kolio","Mitkov", 4),
                new Student("Gencho","Berov", 5),
                new Student("Peshka","Stamatova",6),
                new Student("Zvezdelin","Sokachev",2),
                new Student("Gosho","Stamatov",3),
                new Student("Mitko","Mitkov",4),
                new Student("Barek","Berov",5),
                new Student("Goca","Stamatova",6),
                new Student("Aleksi","Sokachev",2)
            };

            var sortedByGrade = listOfStudents.OrderBy(st => st.Grade).ThenBy(st => st.FirstName);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Sorted students by grades: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student + " " + student.Grade);
            }

            Console.WriteLine(new string('-', 50));

            // Sort Workers by SalaryDescending

            var listOfWorkers = new List<Worker>
            {
                new Worker("Petrohan","Petrov",252,7),
                new Worker("Martin","Krasimirov",400,5),
                new Worker("Kaloyan","Genadiev",1230,8),
                new Worker("Juan","Reyes",1400,14),
                new Worker("Gliukmur","Husev",2324,16),
                new Worker("Ebubechuku","Petrov",100,10),
                new Worker("Pesho","Mariev",749,7),
                new Worker("Peshka","Petrova",800,4),
                new Worker("Divan","Stolov",1728,12),
                new Worker("Skafandur","Bojkov",5400,9),
            };

            var sortedBySalary = listOfWorkers.OrderByDescending(w => w.MoneyPerHours());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Workers by money per hour in descending order: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var worker in sortedBySalary)
            {
                Console.WriteLine(worker + " - " + worker.MoneyPerHours());
            }

            Console.WriteLine(new string('-', 50));

            // Sorted Workers and students by name

            var mergedList = listOfStudents.Concat<Human>(listOfWorkers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sorted by name students and workers: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var person in mergedList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
