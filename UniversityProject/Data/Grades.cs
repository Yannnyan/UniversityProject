using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Data
{
    
    internal class Grades
    {
        private IDictionary<string, int> grades;

        public Grades()
        {
            grades = new Dictionary<string, int>();
        }
        // private throw
        private void throw_unmatched()
        {
            throw (new InvalidDataException("Course non existant."));
        }
        // private throw
        private void throw_matched()
        {
            throw (new InvalidDataException("Course already exists."));
        }
        // adds the grade
        public void addGrade(string courseName, int grade)
        {
            if(grades.ContainsKey(courseName))
            {
                throw_matched();
            }
            grades.Add(courseName, grade);
        }
        // changes the grade
        public void changeGrade(string courseName, int newGrade)
        {
            if(!grades.ContainsKey(courseName))
            {
                throw_unmatched();
            }
            grades[courseName] = newGrade;
        }
        // returns the grade
        public int getGrade(string courseName) 
        {
            if(!grades.ContainsKey(courseName))
            {
                throw_unmatched();
            }
            return grades[courseName];
        }
        // removes a grade
        public int removeGrade(string courseName)
        {
            if(!grades.ContainsKey(courseName))
            {
                throw_unmatched();
            }
            return grades[courseName];
        }
        // returns true if the grades dict exists
        public bool exists ()
        {
            return grades.Count != 0;
        }
    }
}
