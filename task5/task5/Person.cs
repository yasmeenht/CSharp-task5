using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Person
    {
        public String Name;
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value>0 && value<= 120)
                {
                    age = value;
                }
            }
        }

        protected String SchoolName { get; set; }
        private String _internalCode;
        //it can't be accessed outside of this class becasue it's a private field

        public Person(string name, int age, String schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}");
        }

    }
}
