using System;
using System.Collections.Generic;

namespace StudentGrades
{
    class Program
    {
        static void Main()
        {
            var names = new List<string>() {"Adam", "Jan"};
            var numbers = new List<int>() {1, 2, 3};

            foreach(var i in names)
            {
                Console.WriteLine(i);
                foreach (var n in numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
