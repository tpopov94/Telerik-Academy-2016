namespace GroupByGroupNumber
{
    using StudentGroups; // for group class
    using System;
    using System.Linq;

    public class GroupByGroupNumb
    {
        static void Main()
        {

            
            // Task 18 - Create a program that extracts all students grouped by GroupNumber and then prints
            // them to the console.
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task 18 Create a program that extracts all students grouped by GroupNumber and then print them");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var groupedStudents =
                from student in StudentTest.studentList
                group student by student.GroupNumber
                into groups
                select new
                 {
                         Group = groups.Key,
                         Students = groups.ToList()
                 };


            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n--------------\n{1}", grouped.Group,
                string.Join("\r\n", grouped.Students));
                Console.WriteLine(new string('-', 50));
            }

            
            // Task 19 -  Rewrite the previous using extension methods.

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Task 19 -  Rewrite the previous using extension methods.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var groupedStudents2 = StudentTest.studentList.GroupBy(x => x.GroupNumber,
            (groupNumber, students) => new { Group = groupNumber, Students = students });

            foreach (var grouped in groupedStudents2)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                string.Join("\r\n\r\n", grouped.Students));
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
