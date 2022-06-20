using System;
using Xunit;
using StudentGrades;

namespace Students.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
            var Student = new Student("Bartek");
            Student.AddGrade(10);
            Student.AddGrade(53);
            Student.AddGrade(98);

            var result = Student.GetStatistics();

            Assert.Equal(10, result.Lowest);
            Assert.Equal(98, result.Highest);
            Assert.Equal(53.7, result.Average, 1);
        }
    }
}