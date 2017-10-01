using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudent
{
    class Teacher
    {

        public static void Teach()
        {
            Console.WriteLine("Teacher teach student.");
            Student.Learn();
        }

        public static void Answer()
        {
            Console.WriteLine("Teacher answer to students.");
        }
    }
}
