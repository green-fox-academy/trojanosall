using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxAgain
{
    class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            this.level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {level} mentor");
        }
    }
}
