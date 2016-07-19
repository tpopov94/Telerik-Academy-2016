namespace Scool.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolShouldNotThrowAnExceptionWhenCreatedWithValidName()
        {
            var school = new School("Telerik");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullSchoolNameShouldThrowArgumentNullException()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingWhitespaceSchoolNameShouldThrowArgumentNullException()
        {
            var school = new School("        ");
        }
    }
}
