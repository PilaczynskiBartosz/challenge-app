namespace StudentGrades
{
    public class Statistics
    {
        public double Highest;
        public double Lowest;
        public double Sum;
        public double AverageInMemory;
        public int Count;

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            Highest = double.MinValue;
            Lowest = double.MaxValue;
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public string LetterGrade
        {
            get
            {
                switch (Average)
                {
                    case >= 5.5:
                        return "A";

                    case >= 4.75:
                        return "B";

                    case >= 3.75:
                        return "C";

                    case >= 2.75:
                        return "D";

                    case >= 1.75:
                        return "E";

                    case < 1.75:
                        return "F";

                    default:
                        return null;
                }
            }
        }
        public string LetterGradeInMemory
        {
            get
            {
                switch (AverageInMemory)
                {
                    case >= 5.5:
                        return "A";

                    case >= 4.75:
                        return "B";

                    case >= 3.75:
                        return "C";

                    case >= 2.75:
                        return "D";

                    case >= 1.75:
                        return "E";

                    case < 1.75:
                        return "F";

                    default:
                        return null;
                }
            }
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Lowest = Math.Min(number, Lowest);
            Highest = Math.Max(number, Highest);
        }
    }
}