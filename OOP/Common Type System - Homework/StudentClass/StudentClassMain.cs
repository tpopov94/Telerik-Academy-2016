/* Problem 1
    Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
    Use an enumeration for the specialties, universities and faculties.
    Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * Problem 2
    Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 * Problem 3
    Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
*/
namespace StudentClass
{
    using System;

    public class StudentClassMain
    {
        public static void Main()
        {
            var peshoStudent = new Student("Pesho", "Stamatov", "Peshev", 1234, "Address", "0899635423", "pesho@abv.bg", 2, University.MU, Faculties.Dental, Specialities.Medicine);

            var joroStudent = new Student("Joro", "Georgiev", "Peshev", 2234, "Address", "0899635423", "joro@abv.bg", 4, University.TU, Faculties.Telecomunications, Specialities.Tellecomunications);

            Console.WriteLine(peshoStudent.ToString());  // Task 1
            Console.WriteLine("HashCode: {0}",peshoStudent.GetHashCode()); // Task 1
            Console.WriteLine(peshoStudent.Equals(joroStudent)); // Task 1
            Console.WriteLine(peshoStudent == joroStudent);
            Console.WriteLine(peshoStudent != joroStudent);

            var cloneStudent = peshoStudent.Clone(); // Task 2
            Console.WriteLine(new string('-',50));
            Console.WriteLine(cloneStudent.ToString());

            Console.WriteLine(peshoStudent.CompareTo(joroStudent)); // Task 3
            

        }
    }
}
