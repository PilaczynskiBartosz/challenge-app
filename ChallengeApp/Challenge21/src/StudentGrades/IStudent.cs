using System;
using System.Globalization;

namespace StudentGrades
{
    public interface IStudent
    {
        string Name {get; protected set; }
        string Surname { get; protected set; }
        void AddGrade(double grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}