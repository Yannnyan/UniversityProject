using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.Data
{
    public class Debt
    {
        private int studentIDValue;
        public int studentID { get { return studentIDValue; } private set { studentIDValue = value; } }

        private int debtIDValue;
        public int debtID { get { return debtIDValue; } private set { debtIDValue = value; } }
        private double amountValue;
        public double amount { get { return amountValue; } private set { amountValue = value; } }
        private string descriptionValue;
        public string description { get { return descriptionValue; } private set { descriptionValue = value; } }

        public Debt( int debtID, int studentID, double amount, string description)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("cannot make a debt with zero or neg amount");
            }   
            if (studentID < 0 || debtID < 0)
            {
                throw new ArgumentException("cannot make a debt with negative student id or debt id");
            }
            this.studentID = studentID;
            this.debtID = debtID;
            this.amount = amount;
            this.description = description;
        }   
    }
}
