using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    sealed internal class SchoolReport:Person
    {
        public String ReportTitle { get; set; }
        public SchoolReport(String name, int age, String schoolName, String reportTitle):base(name, age, schoolName)
        {
            ReportTitle = reportTitle;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine(this.ReportTitle);
        }

        //No class could inherit from SchoolReport because its sealed
    }
}
