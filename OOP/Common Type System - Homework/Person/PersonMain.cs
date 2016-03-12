/*
    Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
    Override ToString() to display the information of a person and if age is not specified – to say so.
    Write a program to test this functionality.
*/
namespace Person
{
    using System;

    public class PersonMain
    {
        public static void Main()
        {
            var firstPerson = new Person("Pesho",null);
            var secondPerson = new Person("Stamat", 24);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
