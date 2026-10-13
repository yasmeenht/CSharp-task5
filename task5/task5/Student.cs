using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Student : Person
    {
        public int Grade { get; set; }
        private int studentID;
        public int StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                if (value > 0)
                {
                    studentID = value;
                }
            }
        }

        public Student(string name, int age, string schoolName)
    : base(name, age, schoolName)
        {
        }

        public void DisplaySchoolName()
        {
            Console.WriteLine(this.SchoolName);
        }
    }
}