using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Data
{
    internal class University
    {
        private Dictionary<int, Student> students;
        public University()
        {
            students = new Dictionary<int, Student>();
        }

        public void addStudent(Student student)
        {
            students.Add(student.getID(), student);
        }
        public Student getStudent(int id)
        {
            return students[id];
        }
        public Student removeStudent(int id)
        {
            Student student = students[id];
            return student;
        }
    }
}
