using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxAgain
{
    class Pallida
    {
        private string className;
        private List<Student> students = new List<Student>();
        private List<Mentor> mentors = new List<Mentor>();

        public Pallida(string className)
        {
            this.className = className;
            List<Student> students = null;
            List<Mentor> mentors = null;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"{className} class has {students.Count} students and {mentors.Count} mentors.");
        }

    }
}
