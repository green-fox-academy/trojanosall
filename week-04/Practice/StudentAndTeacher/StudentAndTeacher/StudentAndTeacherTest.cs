using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacher
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            var myperson = new Person();
            myperson.Greet();

            var mystudent = new Student();
            mystudent.SetAge(21);
            mystudent.Greet();
            mystudent.Showage();

            var  myteacher = new Teacher();
            myteacher.SetAge(30);
            myteacher.Greet();
            myteacher.Explain();

            Console.ReadKey();
        }
    }
}
