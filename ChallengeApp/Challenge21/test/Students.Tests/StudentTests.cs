using System;
using Xunit;
using StudentGrades;

namespace Students.Tests
{
    public class StudentTests
    {
        [Fact]
        public void CheckStatistics()
        {
            var student = new SavedStudent("Adam", "Nowak");

            student.AddGrade(0.5);
            student.AddGrade(2);
            student.AddGrade(6);
            student.AddGrade(3);

            var stat = student.GetStatistics();

            Assert.Equal(0.5, stat.Lowest);
            Assert.Equal(6, stat.Highest);
            Assert.Equal(2.88, stat.Average, 2);
            Assert.Equal("D", stat.LetterGrade);
        }

        [Fact]
        public void CheckStatisticsWhenNoGrades()
        {
            var student = new SavedStudent("Kacper", "Nowak");

            var stat = student.GetStatistics();

            Assert.True(stat.Lowest == double.MaxValue);
            Assert.True(stat.Highest == double.MinValue);
            Assert.True(double.IsNaN(stat.Average));
            Assert.True(stat.LetterGrade == null);
        }

        [Fact]
        public void ReferenceChecks()
        {
            var student1 = new SavedStudent("Marek", "");
            var student2 = new SavedStudent("Arek", "");
            var student3 = new SavedStudent("Darek", "");
            var student4 = student3;


            Assert.Same(student3, student4);
            Assert.NotSame(student1, student2);
            Assert.NotSame(student2, student3);
            Assert.False(Object.ReferenceEquals(student2, student3));
            Assert.True(Object.ReferenceEquals(student3, student4));
            Assert.False(student2.Equals(student3));
            Assert.True(student3.Equals(student4));
        }
    }
}