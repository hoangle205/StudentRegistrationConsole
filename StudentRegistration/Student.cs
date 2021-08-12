using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int i, string n)
        {
            Id = i;
            Name = n;
        }

        public void Display()
        {
            Console.WriteLine("\n\n" + Id + " " + Name);

        }
    }
}
