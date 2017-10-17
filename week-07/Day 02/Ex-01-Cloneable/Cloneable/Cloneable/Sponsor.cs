using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudent;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
        }

        public Sponsor()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.company = "Google";
            this.hiredStudent = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudent} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudent += hiredStudent;
        }
    }
}
