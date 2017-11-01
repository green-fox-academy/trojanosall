using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudentAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudent = new Student();
            var myTeacher = new Teacher();

            myTeacher.teach();
            myStudent.learn();

            Console.WriteLine();

            myStudent.question();
            myTeacher.answer();

            Console.ReadKey();

        }
    }
}
