using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxAgain
{
    class Student : Person
    {
        private readonly string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            Name = name;
            Age = age;
            Gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            previousOrganization = "The School Life";
            skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
