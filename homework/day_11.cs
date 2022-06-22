using System;
using System.Collections.Generic;

namespace StudentGrades
{
    class Program
    {
        static void Main(String[] args)
        {
            var nameList = new List<string>() {"Adam", "Jan", "Tomasz", "Bartosz", "Piotr", "Darek", "Sławek", "Ola", "Basia", "Zosia"};
            var ageList = new List<int>() {19, 19, 24, 32, 12, 27, 17, 22, 25, 24};
            
            for(var index = 0; index < 10; index++)
            {
                Console.WriteLine(nameList[index] + " " + ageList[index]);
            }
        }
    }
}
