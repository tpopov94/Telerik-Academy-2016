using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using School;

namespace Scool.Tests
{
    [TestClass]
    public class StudentTests
    {
        private Student sampleStudent = new Student("Pesho", "Peshov");

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullFistNameShouldThrowArgumentNullException()
        {
            var student = new Student(null, "Peshov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullLastNameShouldThrowArgumentNullException()
        {
            var student = new Student("Pesho", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingFirstNameWithLessThanTwoSymbolsShouldThrowArgumentOutOfRangeException()
        {
            var student = new Student("P", "Peshov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingLastNameWithLessThanTwoSymbolsShouldThrowArgumentOutOfRangeException()
        {
            var student = new Student("Pesho", "P");
        }

        [TestMethod]
        public void StudentFullNameShouldConsistOfFirstNameAndLastName()
        {
            Assert.AreEqual("Pesho Peshov", sampleStudent.FullName, "Full name is not correct");
        }

        [TestMethod]
        public void StudentShouldBeCreatedWithTheExpectedValidProperties()
        {
            var sampleStudent2 = new Student("Pesho", "Peshov");
            Assert.AreEqual("Pesho", sampleStudent2.FirstName, "Expected first name is not correct");
            Assert.AreEqual("Peshov", sampleStudent2.LastName, "Expected last name is not correct");
            Assert.AreEqual(10000, sampleStudent2.UniqueNumber, "Sample student ID number is not 10000");
            Assert.AreEqual(0, sampleStudent2.CoursesList.Count, "Student is not created with 0 courses");
        }

        //[TestMethod]
    }
}
