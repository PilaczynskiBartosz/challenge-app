using System;
using System.Globalization;

namespace StudentGrades
{    
    public class NamedObject
    {
        public NamedObject(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}