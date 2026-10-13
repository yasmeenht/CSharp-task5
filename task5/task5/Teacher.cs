using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Teacher:Person
    {
        public String Subject { get; set; }
        public Teacher(String Name, int Age, String SchoolName, String Subject):base(Name, Age, SchoolName)
        {
            this.Subject = Subject;
        }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher's Name: {this.Name}\n" +
                $"Teacher's Age: {this.Age}\n" +
                $"Subject: {this.Subject}");
        }
    }
}
