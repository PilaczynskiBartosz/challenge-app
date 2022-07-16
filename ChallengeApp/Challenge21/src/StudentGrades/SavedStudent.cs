using System;
using System.Globalization;

namespace StudentGrades
{
    public class SavedStudent : StudentBase
    {
        private List<double> grades;

        public SavedStudent(string name, string surname) : base(name, surname)
        {
            grades = new List<double>();
        }

        public override event GradeAddedDelegate GradeAdded;
        const string auditPath = "audit.txt";

        public override void AddGrade(double grade)
        {
            using (var audit = File.AppendText(auditPath))
            using (var writer = File.AppendText($"{Name}{Surname}.txt"))
            {
                if (grade >= 0 && grade <= 6)
                {
                    writer.WriteLine(grade);
                    audit.WriteLine(grade + " " + DateTime.UtcNow);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new ArgumentException($"Invalid argument: {nameof(grade)}");
                }
            }
        }

        public override void AddGrade(string grade)
        {
            var stringChecklist = new List<string>() { "1", "2", "3", "4", "5", "6", "1+", "2+", "3+", "4+", "5+", "6+", "1-", "2-", "3-", "4-", "5-", "6-" };
            var result = double.Parse(grade.Substring(0, 1));

            if (stringChecklist.Contains(grade))
            {
                if (grade.Contains("+"))
                {
                    result += 0.5;
                    AddGradeIfContent(result);
                }
                else if (grade.Contains("-"))
                {
                    result -= 0.25;
                    AddGradeIfContent(result);
                }
                else
                {
                    AddGradeIfContent(result);
                }
            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(grade)}");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var audit = File.OpenText(auditPath))
            using (var reader = File.OpenText($"{Name}{Surname}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
        private void AddGradeIfContent(double result)
        {
            using (var audit = File.AppendText(auditPath))
            using (var writer = File.AppendText($"{Name}{Surname}.txt"))
            {
                this.grades.Add(result);
                writer.WriteLine(result);
                audit.WriteLine(result + " " + DateTime.UtcNow);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }
    }
}