namespace Scool.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;

    [TestClass]
    public class CourseTests
    {
        private Course sampleCourse = new Course("Unit Testing");

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullTitleShouldThrowArgumentNullException()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingEmptyTitleShouldThrowArgumentNullException()
        {
            var course = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddintNullStudentToStudentsListShouldThrowNewArgumentNullException()
        {
            sampleCourse.AddStudent(new Student(null, "Sigurdson"));
        }

        [TestMethod]
        public void AddingNewStudentToTheCourseShouldIncreaseStundentsInCourseByOne()
        {
            sampleCourse.AddStudent(new Student("Pesho", "Peshovson"));

            Assert.AreEqual(1, sampleCourse.StudentsList.Count, "Students list is not updated correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AddingTheSameStudentTwiceInOneCourseShouldThrowApplicationException()
        {
            var ragnarStudent = new Student("Ragnar", "Peshovski");
            sampleCourse.AddStudent(ragnarStudent);
            sampleCourse.AddStudent(ragnarStudent);
        }
    }
}
