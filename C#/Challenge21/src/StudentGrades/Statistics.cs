namespace StudentGrades
{
    public class Statistics
    {
        public double Highest;
        public double Lowest;
        public double Sum;
        public int Count;

        public Statistics()
        {
            Count =0;
            Sum = 0.0;
            Highest = double.MinValue;
            Lowest = double.MaxValue;
        }

        public double Average
        {
            get
            {
                return Sum/Count;
            }
        }

        public string LetterGrade
        {
            get
            {
                switch(Average)
                {
                    case var d when d >= 5.5:
                        return "A";
                        
                    case var d when d >= 4.75:
                        return "B";
                    
                    case var d when d >= 3.75:
                        return "C";
                    
                    case var d when d >= 2.75:
                        return "D";
                    
                    case var d when d >= 1.75:
                        return "E";
                                   
                    case var d when d >= 0.5:
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