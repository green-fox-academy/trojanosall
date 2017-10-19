using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    class Cat : Animal
    {
        public Cat(int age = 1, string name = "Garfield")
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} is {age} years old cat";
        }
    }
}