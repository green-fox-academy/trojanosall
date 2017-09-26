using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxInheritance
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

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

        public void Introduce(string name, int age, string gender)
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.", name, age, gender);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
