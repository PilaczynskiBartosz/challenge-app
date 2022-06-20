using System;
using Xunit;
using StudentGrades;

namespace Students.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetStudentReturnsDifferentObjects()
        {
            var stu1 = GetStudent("Adam");
            var stu2 = GetStudent("Bartek");

            Assert.Equal("Adam", stu1.Name);
            Assert.Equal("Bartek", stu2.Name);

            Assert.NotSame(stu1, stu2);
        }
        private Student GetStudent(string name)
        {
            return new Student(name);
        }
    }
}
