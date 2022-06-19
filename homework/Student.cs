namespace ChallangeApp
{
    public class Student
    {
        private string name;
        private List<double> grades = new List<double>();

        public Student(string name)
        {
            this.name = name;
        }

        public void addGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(70);
                    break;
                case 'D':
                    this.grades.Add(60);
                    break;
                case 'E':
                    this.grades.Add(50);
                    break;
                case 'F':
                    this.grades.Add(40);
                    break;
                default:
                    this.grades.Add(0);
                    break;
            }
        }
        public Statistics getStatistics(){
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            result.Mark = 0;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
    }
}
