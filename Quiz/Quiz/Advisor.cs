using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Personclass;
using System.Xml.Linq;

namespace Quiz
{
    public class Advisor
    {
        public string Name { get; set; }
        public string Major { get; set; }
        private List<Student> students = new List<Student>();

        public Advisor(string name, string major)
        {
            Name = name;
            Major = major;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            student.Advisor = this;
        }

        public Student GetTopStudent()
        {
            if (students.Count == 0)
                return null;

            return students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}