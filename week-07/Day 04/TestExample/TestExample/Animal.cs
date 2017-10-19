using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    class Animal
    {
        protected int age;
        protected string name;

        public Animal(int age = 1, string name = "Beast")
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} is {age} years old animal";
        }
    }
}
