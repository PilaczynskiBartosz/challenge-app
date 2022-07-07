using System;
using System.Collections.Generic;

namespace StudentGrades
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Give the student's name");
            string name = Console.ReadLine();
            Console.WriteLine("Give the student's surname");
            string surname = Console.ReadLine();

            var Student = new SavedStudent($"{name}", $"{surname}");

            EnterGrade(Student);

            var stats = Student.GetStatistics();
            Console.WriteLine($"Highest: {stats.Highest}");
            Console.WriteLine($"Lowest: {stats.Lowest}");
            Console.WriteLine($"Average: {stats.Average}");
            Console.WriteLine($"Letter grade: {stats.LetterGrade}");
        }

        private static void EnterGrade(IStudent Student)
        {
            while (true)
            {
                Console.WriteLine($"Hello! Enter grade for {Student.Name} {Student.Surname}");
                Console.WriteLine("Press 'q' to exit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = input;

                    if (int.Parse(grade.Substring(0, 1)) <= 3)
                    {
                        Student.GradeAdded += OnGradeAdded;
                        Student.AddGrade(grade);
                        Student.GradeAdded -= OnGradeAdded;
                    }
                    else
                    {
                        Student.AddGrade(grade);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Oh no! We should inform student's parents about this fact");
        }
    }
}