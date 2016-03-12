namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        public static List<Student> studentList = new List<Student> // Task 9 Making list of Students
            {
                new Student("Blagoi", "Kirov", "100006", "029270892", "stamat@yahoo.com",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.Poor }, 2),
                new Student("Stamat", "Gagarin", "123434", "+359270892", "stamat@abv.com",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average ,(int) Marks.Poor}, 3),
                new Student("Pesho", "Gecov", "343406", "05234141", "pesho@abv.bg",
                new List<int> { (int) Marks.Poor, (int)Marks.Average,(int) Marks.Poor }, 4),
                new Student("Joro", "Andonov", "334406", "09270892", "joro4@vip.bg",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.VeryGood }, 12),
                new Student("Ivcho", "Berbatov", "053432", "359886200300", "barbukov@gmail.com",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average,(int) Marks.Poor }, 2),
                new Student("Peshka", "Zarkova", "762406", "049270892", "peshkaNaB5@abv.bg",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.Excellent }, 2),
                new Student("Goca", "Jodjeva", "000304", "029273242", "gockaMacka@gmail.com",
                new List<int> { (int) Marks.Poor, (int)Marks.Good, (int)Marks.Excellent }, 3),
                new Student("Dochka", "Kirilova", "913734", "029270896", "Dochka@gmail.com",
                new List<int> { (int)Marks.Excellent, (int)Marks.VeryGood, (int)Marks.Excellent }, 2),
                new Student("Ebubechuku", "Chuku", "340137", "9270892", "ebubi@abv.bg",
                new List<int> { (int)Marks.Excellent,(int) Marks.Poor,(int) Marks.Poor }, 2),
                new Student("Kliment", "Ohridski", "345656", "+35992740892", "KO@gmail.com",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.Excellent }, 1),
                new Student("Skafandur", "Sputnikov", "346506", "+35928200300", "skafi77@abv.bg",
                new List<int> { (int)Marks.Excellent, (int)Marks.Average,(int) Marks.Poor }, 2)
            };
        static void Main()
        {
            //var studentList = new List<Student> // Task 9 Making list of Students
            //{
            //    new Student("Blagoi", "Kirov", "100006", "029270892", "stamat@yahoo.com",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.Poor }, 2),
            //    new Student("Stamat", "Gagarin", "123434", "+359270892", "stamat@abv.com",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average ,(int) Marks.Poor}, 3),
            //    new Student("Pesho", "Gecov", "343406", "05234141", "pesho@abv.bg",
            //    new List<int> { (int) Marks.Poor, (int)Marks.Average,(int) Marks.Poor }, 4),
            //    new Student("Joro", "Andonov", "334406", "09270892", "joro4@vip.bg",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.VeryGood }, 12),
            //    new Student("Ivcho", "Berbatov", "053432", "359886200300", "barbukov@gmail.com",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average,(int) Marks.Poor }, 2),
            //    new Student("Peshka", "Zarkova", "762406", "049270892", "peshkaNaB5@abv.bg",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.Excellent }, 2),
            //    new Student("Goca", "Jodjeva", "000304", "029273242", "gockaMacka@gmail.com",
            //    new List<int> { (int) Marks.Poor, (int)Marks.Good, (int)Marks.Excellent }, 3),
            //    new Student("Dochka", "Kirilova", "913734", "029270896", "Dochka@gmail.com",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.VeryGood, (int)Marks.Excellent }, 2),
            //    new Student("Ebubechuku", "Chuku", "340137", "9270892", "ebubi@abv.bg",
            //    new List<int> { (int)Marks.Excellent,(int) Marks.Poor,(int) Marks.Poor }, 2),
            //    new Student("Kliment", "Ohridski", "345656", "+35992740892", "KO@gmail.com",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average, (int)Marks.Excellent }, 1),
            //    new Student("Skafandur", "Sputnikov", "346506", "+35928200300", "skafi77@abv.bg",
            //    new List<int> { (int)Marks.Excellent, (int)Marks.Average,(int) Marks.Poor }, 2)
            //};

            #region Task 9
            // Task 9 Select only the students that are from group number 2.
            //Use LINQ. Order the students by FirstName.

            var taskNine =
                from st in studentList
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Task 9 Select only the students that are from group number 2");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));
            Print(taskNine);

            #endregion

            #region Task 10
            // Task 10 Select only the students that are from group number 2. Order the students by FirstName

            var taskTen = studentList.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 10 Select only the students that are from group number 2 lambda expression");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            Print(taskTen);
            #endregion

            #region Task 11 Extract all students that have email in abv.bg
            // Task 11 Extract all students that have email in abv.bg
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Task 11 Extract all students that have email in abv.bg LINQ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var taskEleven =
                from st in studentList
                where st.Email.Contains("@abv.bg")
                select st;

            Print(taskEleven);
            #endregion

            #region Task 12 Extract all students with phones in Sofia. Use LINQ
            // Task 12 Extract all students with phones in Sofia. Use LINQ
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 12 Extract all students with phones in Sofia (02 or +3592). Use LINQ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var taskTwelve =
                from st in studentList
                where st.Tel.StartsWith("02") || st.Tel.StartsWith("+3592")
                select st;

            Print(taskTwelve);
            #endregion

            #region Task 13 Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks
            // Task 13 Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Task 13 Select all students that have at least one mark Excellent (6). Use LINQ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var taskThirteen =
                from st in studentList
                where st.Marks.Contains((int)Marks.Excellent)
                select new
                {
                    fullName = st.FirstName + " " + st.LastName,
                    marks = st.Marks
                };

            foreach (var student in taskThirteen)
            {
                Console.WriteLine("Full name: {0}", student.fullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.marks));
                Console.WriteLine(new string('-', 50));
            }
            #endregion

            #region Task 14 Write down a program that extracts the students with exactly two marks "2"
            // Task 14 Write down a program that extracts the students with exactly two marks "2"
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task 14 Write down a program that extracts the students with exactly two marks \"2\"");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var taskFourteen = studentList.Where(st => st.Marks.FindAll(x => x == 2).Count == 2)
                .Select(st => new
                {
                    fullName = st.FirstName + " " + st.LastName,
                    marks = st.Marks
                });

            foreach (var student in taskFourteen)
            {
                Console.WriteLine("Full name: {0}", student.fullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.marks));
                Console.WriteLine(new string('-', 50));
            }
            #endregion

            #region Task 15 Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            // Task 15 Extract all Marks of the students that enrolled in 2006."
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Task 15 Extract all Marks of the students that enrolled in 2006. (5-th and 6-th digit in the FN are 06)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            var taskFivteen = studentList.Where(st => st.FN[4] == '0' && st.FN[5] == '6')
                .Select(st => new
                {
                    fullName = st.FirstName + " " + st.LastName,
                    marks = st.Marks
                });

            foreach (var student in taskFivteen)
            {
                Console.WriteLine("Full name: {0}", student.fullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.marks));
                Console.WriteLine(new string('-', 50));
            }
            #endregion

            #region Task 16  Extract all students from "Mathematics" department. Use the Join operator.
            // Task 16 Extract all students from "Mathematics" department. Use the Join operator.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Task 16 Extract all students from \"Mathematics\" department. Use the Join operator.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 50));

            Group group1 = new Group(1, "Sports");
            Group group2 = new Group(2, "Mathematics");
            Group group3 = new Group(3, "Farmacy");
            Group group4 = new Group(3, "Medicine");

            List<Group> groups = new List<Group> { group1, group2, group3, group4 };

            var taskSixteen =
            from someGroup in groups
            where someGroup.GroupNumber == 2

            join student in studentList on someGroup.GroupNumber equals student.GroupNumber

            select new // creating new anonymous class after matching group numbers from the Student class
            { // and the Group class to get Name from the Student instances and department from the Group ones
                Name = student.FirstName + " " + student.LastName,
                Department = someGroup.DepartmentName
            };

            Console.WriteLine("All students from mathematics department, extracted as new anonymous classes,");
            foreach (var student in taskSixteen)
            {
                Console.WriteLine(student);
            }
            #endregion
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
