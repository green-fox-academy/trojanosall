using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxAgain
{
    class Person
    {
        protected string Name;
        protected int Age;
        protected string Gender;

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi {Name}, a {Age} years old {Gender}");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }


    }
}
