using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Data
{
    
    public class Grade
    {
        private int gradeIDValue;
        public int gradeID { get { return gradeIDValue; } private set { gradeIDValue = value; } }
        private string courseNameValue;
        public string courseName { get { return courseNameValue; } private set { courseNameValue = value; } }
        private int gradeValue;
        public int grade { get { return gradeValue; } private set { gradeValue = value; } }

        private int studentIDValue;
        public int studentID { get { return studentIDValue; } private set { studentIDValue = value; } }
        public Grade(string courseName, int grade, int gradeID, int studentID)
        {
            if (courseName is null)
            {
                throw (new ArgumentNullException("course name cannot be null"));
            }
            if (grade < 0)
            {
                throw (new ArgumentException("grade cannot have negative value"));
            }
            else if (grade > 100)
            {
                throw (new ArgumentException("grade cannot score more than 100 points"));
            }
            if (gradeID < 0)
            {
                throw (new ArgumentException("gradeID cannot be negative"));
            }
            this.courseName = courseName;
            this.grade = grade;
            this.gradeID = gradeID;
            this.studentID = studentID;
        }


    }
}
