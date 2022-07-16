using System;
using System.Globalization;

namespace StudentGrades
{
    public interface IStudent
    {
        void AddGrade(double grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}