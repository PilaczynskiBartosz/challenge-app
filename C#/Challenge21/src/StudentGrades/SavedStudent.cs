using System;
using System.Globalization;

namespace StudentGrades
{
    public class SavedStudent : StudentBase, IStudent
    {
        private List<double> grades;

        public SavedStudent(string name, string surname) : base(name, surname)
        {
            grades = new List<double>();
        }
        
        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using(var audit = File.AppendText("audit.txt"))
            using(var writer = File.AppendText($"{Name}{Surname}.txt"))
            {
                if(grade >= 0 && grade <= 6)
                {
                    writer.WriteLine(grade);
                    audit.WriteLine(grade +" "+ DateTime.UtcNow);
                    if(GradeAdded != null)
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
            var stringChecklist=new List<string>() {"1","2","3","4","5","6","1+","2+","3+","4+","5+","6+","1-","2-","3-","4-","5-","6-"};
            var result=double.Parse(grade.Substring(0,1));

            using(var audit = File.AppendText("audit.txt"))
            using(var writer = File.AppendText($"{Name}{Surname}.txt"))
            {
                if(stringChecklist.Contains(grade))
                {
                    if(grade.Contains("+"))
                    {
                        result+=0.5;
                        this.grades.Add(result);
                        writer.WriteLine(result);
                        audit.WriteLine(result +" "+ DateTime.UtcNow);
                        if(GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }                
                    }
                    else if(grade.Contains("-"))
                    {
                        result-=0.25;
                        this.grades.Add(result);
                        writer.WriteLine(result);
                        audit.WriteLine(result +" "+ DateTime.UtcNow);
                        if(GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        } 
                    }
                    else
                    {
                        this.grades.Add(result);
                        writer.WriteLine(result);
                        audit.WriteLine(result +" "+ DateTime.UtcNow);
                        if(GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        } 
                    }
                }
                else
                {
                    throw new ArgumentException($"Invalid argument: {nameof(grade)}");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using(var audit = File.OpenText("audit.txt"))
            using(var reader = File.OpenText($"{Name}{Surname}.txt"))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }
            
            return result;
        }
    }
}