using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Yasmeen", 22, "School");
            //Console.WriteLine(p1.SchoolName);
            //Console.WriteLine(p1._internalCode);

            //protected & private fields can't be accessed from outside of the class.


            Student s1 = new Student("Yasmeen", 22, "Yarmouk");
            s1.Grade = 95;
            s1.StudentID = 101;

            Student s2 = new Student("Sara", 21, "Oxford");
            s2.Grade = 90;
            s2.StudentID = 102;

            // Create a Teacher object
            Teacher t1 = new Teacher("Ahmad", 35, "Yarmouk", "Math");

            // Display Student information
            s1.DisplayInfo();
            s2.DisplayInfo();

            // Display Teacher information
            t1.DisplayTeacherInfo();

            // Create a SchoolReport object
            SchoolReport report1 = new SchoolReport(
                "Yasmeen", 22, "Yarmouk", "Final Report"
            );

            // Display report title
            report1.DisplayReportTitle();
        }
    }
}
