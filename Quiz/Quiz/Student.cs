using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Personclass;
using System.Xml.Linq;

namespace Quiz
{

    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public double Grade { get; set; }
        public Advisor Advisor { get; set; }

        public Student(string id, string name, string major, double grade)
        {
            StudentID = id;
            Name = name;
            Major = major;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{StudentID} - {Name}";
        }
    }
}