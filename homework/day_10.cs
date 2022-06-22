using System;
using System.Globalization;

namespace StudentGrades
{
    public class Student
    {
        public void ChangeName(Student Name, string newName)
        {
            var error = 0;
            
            if(newName != null){
                
                foreach(var n in newName)
                {
                    if(char.IsDigit(newName, n))
                    {
                        error = 1;
                    }
                }
                
                if(error == 1)
                {
                    Console.WriteLine("Name cannot include numbers");
                }
                else
                {
                    this.Name = newName;
                }
            }
            else
            {
                Console.WriteLine("Name cannot be empty");
            }
        }
    }
}
