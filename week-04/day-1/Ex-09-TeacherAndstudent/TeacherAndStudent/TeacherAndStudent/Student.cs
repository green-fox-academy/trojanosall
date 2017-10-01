using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudent
{
    class Student
    {
        public static void  Learn()
        {
            Console.WriteLine("Student learn from Teacher.");
        }

        public static void Question()
        {
            Console.WriteLine("Student ask their Teacher.");
            Teacher.Answer();
        }
    }
}
