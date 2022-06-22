using System;
using System.Globalization;

namespace StudentGrades
{
    public class Student
    {
            public void AddGradeStr(string grade)
            {
            bool success = int.TryParse(grade, out int numberGrade);
            if(success)
            {
                if(numberGrade >= 0 && numberGrade <= 100)
                {
                    this.grades.Add(numberGrade);
                }
                else
                {
                    Console.WriteLine($"Couldn't add {grade} to list. Invalid value");
                }
            }
            else
            {
                Console.WriteLine($"Couldn't add {grade} to list. Invalid value");
            }
        }
    }
}
