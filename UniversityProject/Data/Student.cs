using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Data
{
    internal class Student
    {
        private string name;
        private int id;
        private Grades grades;
        private Debts debts;
        

        public Student(int id, string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name cant be null");
            }
            this.id = id;
            this.name = name;
            grades = new Grades();
            debts = new Debts();
            
        }

        public Grades getGrades()
        {
            if(grades.exists())
            {
                return grades;
            }
            return null;
        }
        public Debts getDebts()
        {
            return debts;
        }
        public int getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }


    }
}
