using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxInheritance
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }


        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.PreviousOrganization = "to The School of Life";
            this.SkippedDays = 0;

        }
        
        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void Introduce(string name, int age, string gender, string previousOrganization, int skippedDays)
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
            
        }

    }
}
