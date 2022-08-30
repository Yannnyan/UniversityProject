using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Data
{
    public class Student
    {
        private string nameValue;
        public string name { get { return nameValue; } private set { nameValue = value; } }
        private int idValue;
        public int id { get { return idValue; } private set { idValue = value; } }
        private ArrayList gradesValue;
        public ArrayList grades { get { return gradesValue; } private set { gradesValue = value; } }
        private ArrayList debtsValue;
        public ArrayList debts { get { return debtsValue; } private set { debtsValue = value; } }
        

        public Student(int id, string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name cant be null");
            }
            this.id = id;
            this.name = name;
            grades = new ArrayList();
            debts = new ArrayList();
                    
        }
        public Student(int id, string name, ArrayList grades, ArrayList debts)
        {
            if (name is null || grades is null || debts is null)
            {
                throw new ArgumentNullException("parameter is null");
            }
            this.id = id;
            this.name = name;
            this.grades = grades;
            this.debts = debts;
        }
        // inserts a new grade into the arraylist
        // not updates the db
        public void addGrade(Grade grade)
        {
            this.grades.Add(grade);
        }
        public void addDebt(Debt debt)
        {
            this.debts.Add(debt);
        }

    }
}
