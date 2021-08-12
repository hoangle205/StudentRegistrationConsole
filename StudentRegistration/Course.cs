using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Course
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Course(string n, string d)
        {
            Name = n;
            Desc = d;
        }

        public void Display()
        {
            Console.WriteLine("\n\n" + Name + " " + Desc);

        }
    }
}
