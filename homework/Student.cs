namespace StudentGrades
{
    public class Student
    {
        private string name;
        private List<int> grades = new List<int>();

        public Student(string name)
        {
            this.name = name;
        }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Highest = double.MinValue;
            result.Lowest = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Lowest = Math.Min(grade, result.Lowest);
                result.Highest = Math.Max(grade, result.Highest);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
    }
}
