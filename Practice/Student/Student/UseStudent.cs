using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class UseStudent
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(1, "ABC", "asp.net");

            myStudent.Payment(1000);

            myStudent.Print();

            Console.WriteLine(myStudent.DueAmount);

            Console.ReadKey();
        }
    }
}
