using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Personclass
{
    internal abstract class Person
    {
        // คุณสมบัติพื้นฐานของบุคคล
        protected string name;
        protected string major;

        // Constructor
        public Person(string name, string major)
        {
            this.name = name;
            this.major = major;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        // Abstract method ที่คลาสลูกต้อง implement
        public abstract string GetInfo();
    }
}
