namespace SortStudentsTask3_5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortStudentsMain
    {
        static void Main()
        {
            Student[] arrayOfStudents =
            {
                new Student("Spas", "Kirov", 12),
                new Student("Manol", "Spasov", 22),
                new Student("Skafandur", "Milkov", 50),
                new Student("Stamat", "Dimitrov", 19),
                new Student("Mincho", "Todorov", 27),
                new Student("Minkov", "Ivanov", 27),
                new Student("Pesho", "E KAK BEZ PESHO", 18),
                new Student("Sladun", "Goranov", 37)
            };

            //All students
            Console.WriteLine("All students:\n");
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": {0} {1} Age: {2}", arrayOfStudents[i].FirstName, arrayOfStudents[i].LastName, arrayOfStudents[i].Age);
            }

            Console.WriteLine(new string('-', 50));
            // Task 3 Sort by firstName compared to lastName

            Console.WriteLine("Task 3 Sort by firstName compared to lastName:");
            var sortedByFirstBeforeLastName = OrderByFirstNameBeforeLast(arrayOfStudents);

            foreach (var item in sortedByFirstBeforeLastName)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine(new string('-', 50));
            // Task 4 Sort by age range (18-24)

            Console.WriteLine("Task 4 Sort by age range (18-24):");
            var sortedByAgeRange = AgeRange(arrayOfStudents);

            foreach (var student in sortedByAgeRange)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " Age: " + student.Age);
            }

            Console.WriteLine(new string('-', 50));
            // Task 5 Order by first name and last name descending

            Console.WriteLine("Task 5 Order by first name and last name descending LINQ ");

            var orderByNameLinq = OrderStudents(arrayOfStudents);

            foreach (var student in orderByNameLinq)
            {
                 Console.WriteLine(student.FirstName + " " + student.LastName + " Age: " + student.Age);
            }

            Console.WriteLine(new string('-', 50));
            // Task 5 Order by first name and last name descending

            Console.WriteLine("Task 5 Order by first name and last name descending Extension methods and lambda ");
            var orderByExtAndLamda = arrayOfStudents
                                    .OrderByDescending(st => st.FirstName)
                                    .ThenByDescending(st => st.LastName); // Task 5 Extension methods and lambda

            foreach (var student in orderByExtAndLamda)
            {
                 Console.WriteLine(student.FirstName + " " + student.LastName + " Age: " + student.Age);
            }
        }

        public static IEnumerable<Student> OrderByFirstNameBeforeLast(Student[] arrayOfStudents) // Task 3
        {
            var sorted =
               from st in arrayOfStudents
               where st.FirstName.CompareTo(st.LastName) < 0
               select st;

            return sorted;
        }

        public static IEnumerable<Student> AgeRange(Student[] arrayOfStudents) // Task 4
        {
            var sorted =
                from st in arrayOfStudents
                where st.Age >= 18 && st.Age <= 24
                select st;

            return sorted;
        }

        public static IEnumerable<Student> OrderStudents(Student[] arrayOfStudents) // Task 5 LINQ
        {
            var sorted =
                from st in arrayOfStudents
                orderby st.FirstName descending, st.LastName descending
                select st;

            return sorted;
        }
    }
}
