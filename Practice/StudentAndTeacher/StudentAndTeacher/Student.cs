using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacher
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void Showage()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }
}
