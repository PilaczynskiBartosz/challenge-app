using System.Collections.Generic;

namespace StudentGrades
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public abstract class StudentBase : NamedObject, IStudent
    {
        public StudentBase(string name, string surname) : base(name, surname)
        {
        }
        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
    }
}