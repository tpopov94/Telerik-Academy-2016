namespace Scool.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;

    [TestClass]
    public class StudentTests
    {
        private Student sampleStudent = new Student("Pesho", "Peshov");
        private Course sampleCourse = new Course("Grucki");

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
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingStudentWithEmptyStringAsFirstNameShouldThrowArgumentNullException()
        {
            var student = new Student("", "Peshov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingStudentWithEmptyStringAsLastNameShouldThrowArgumentNullException()
        {
            var student = new Student("Pesho", "");
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
            Assert.AreEqual("Pesho", sampleStudent.FirstName, "Expected first name is not correct");
            Assert.AreEqual("Peshov", sampleStudent.LastName, "Expected last name is not correct");
            Assert.AreEqual(School.UniqueNumber, sampleStudent.UniqueNumber, "Sample student ID number is not 10000");
            Assert.AreEqual(0, sampleStudent.CoursesList.Count, "Student is not created with 0 courses");
        }

        [TestMethod]
        public void AddingNewCourseShouldNotThrowAnException()
        {
            sampleStudent.SignCourse(sampleCourse);
        }

        [TestMethod]
        public void AddingNewCourseShouldUpdateCourseCounterCorrectly()
        {
            sampleStudent.SignCourse(sampleCourse);
            sampleStudent.SignCourse(sampleCourse);

            Assert.AreEqual(2, sampleStudent.CoursesList.Count, "Student Course list is not updated properly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullCourseToStudentShouldThrowArgumentNullException()
        {
            sampleStudent.SignCourse(null);
        }

        [TestMethod]
        public void RemovingNewCourseShouldNotThrowAnException()
        {
            sampleStudent.UnsignCourse(sampleCourse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingNullCourseToStudentShouldThrowArgumentNullException()
        {
            sampleStudent.UnsignCourse(null);
        }
    }
}
