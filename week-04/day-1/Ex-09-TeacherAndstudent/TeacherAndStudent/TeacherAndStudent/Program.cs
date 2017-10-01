using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teacher Student

            // Create Student and Teacher classes
            // Student
            // learn()
            // question(teacher)->calls the teachers answer method
            // Teacher
            // teach(student)->calls the students learn method
            // answer()

            Teacher.Teach();
            Student.Learn();

            Student.Question();
            Teacher.Answer();

            Console.ReadKey();

        }
    }
}
