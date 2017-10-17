using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    public class Palida
    {
        private string className;
        private List<Student> studentList = new List<Student>();
        private List<Mentor> mentorList = new List<Mentor>();

        public Palida(string className)
        {
            this.className = className;
            this.studentList = null;
            this.mentorList = null;
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentorList.Add(mentor);
        }
    }
}