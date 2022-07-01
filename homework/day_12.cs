        public void AddGrade(string grade)
        {
            var stringChecklist=new List<string>() {"1","2","3","4","5","6","1+","2+","3+","4+","5+","6+","1-","2-","3-","4-","5-","6-"};
            var result=double.Parse(grade.Substring(0,1));

            if(stringChecklist.Contains(grade))
            {
                if(grade.Contains("+"))
                {
                    result+=0.5;
                    this.grades.Add(result);
                }
                else if(grade.Contains("-"))
                {
                    result-=0.25;
                    this.grades.Add(result);
                }
                else
                {
                    this.grades.Add(result);
                }
            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(grade)}");
            }
        }
