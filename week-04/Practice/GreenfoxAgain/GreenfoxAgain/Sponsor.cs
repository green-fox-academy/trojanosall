using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxAgain
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudent;

        public Sponsor(string name, int age, string gender, string company)
        {
            Name = name;
            Age = age;
            Gender = gender;
            this.company = company;
            this.hiredStudent = 0;
        }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            this.company = "Google";
            this.hiredStudent = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {company} and hired {hiredStudent} students so far");
        }

        public void Hire()
        {
            hiredStudent += 1;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
