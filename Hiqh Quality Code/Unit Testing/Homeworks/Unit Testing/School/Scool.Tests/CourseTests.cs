namespace Scool.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;

    [TestClass]
    public class CourseTests
    {
        /*private Course sampleCourse = new Course("Unit Testing");
        private Student sampleStudent = new Student("Kircho", "Ronaldov");

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingMoreThanTwentyNineStudentsShoudCauseArgumentOutOfRangeException()
        {
            var newCourse = new Course("C# for dummys");
            for (int i = 0; i < 30; i++)
            {
                var student = new Student("Pesho" + i, "Peshev");
                newCourse.AddStudent(student);
            }
        }

        [TestMethod]
        public void RemovingStudentsFromCourseShouldUpdateStudentsListCountProperly()
        {
            var newCourse = new Course("C# for dummys");
            for (int i = 0; i < 9; i++)
            {
                var student = new Student("Kircho" + i, "Ronaldov");
                newCourse.AddStudent(student);
            }
            newCourse.AddStudent(sampleStudent);
            newCourse.RemoveStudent(sampleStudent);

            Assert.AreEqual(9, newCourse.StudentsList.Count, "StudentsList counter is not updated properly after removing a student");
        }*/

































    }
}
