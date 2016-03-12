/*We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 * Each teacher teaches, a set of disciplines. Students have a name and unique class number. 
 * Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. 
 * Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
 * define the class hierarchy and create a class diagram with Visual Studio.*/


namespace School
{
    using System;
    using System.Collections.Generic;

    class MainProgram
    {
        static void Main()
        {
            // Testing 

            var listOfStudents = new List<Student>
            {
                new Student("Pesho","Stamatov",123),
                new Student("Kolio","Mitkov",124),
                new Student("Gencho","Berov",125),
                new Student("Peshka","Stamatova",126),
                new Student("Zvezdelin","Sokachev",127)
            };

            var listOfDisciplines = new List<Discipline>
            {
               // new Discipline(DisciplinesList.Arts, 23,23),
               // new Discipline(DisciplinesList.French, 23,43),
                new Discipline(DisciplinesList.ComputerScience, 123,23),
                new Discipline(DisciplinesList.Mathematics, 23,231),
                new Discipline(DisciplinesList.Sports, 23312,2233)
            };

            // All teachers have the same disciplines to save space - you may try to change them if you want : )
            var listOfTeachers = new List<Teacher> 
            { 
                new Teacher("Aleksandrina", "Todorova", listOfDisciplines),
                new Teacher("Cvetelina", "Licheva", listOfDisciplines),
                new Teacher("Jana", "Dimova", listOfDisciplines),
                new Teacher("Maia", "Mitkova", listOfDisciplines),
                new Teacher("Konstantin", "Koinov", listOfDisciplines),
            };

            var schoolClass = new Classes(listOfTeachers, listOfStudents, "12A");

            var pesho = new Student("Pesho", "Stamtliev", 2);
            pesho.AddComment("Ne moje bez Pesho");
            Console.WriteLine(pesho.ShowComments());
        }
    }
}