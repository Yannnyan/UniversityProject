using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Data
{
    internal class Debts
    {
        private double studyDebt;
        private double headDebt;
        
        public Debts()
        {
            studyDebt = 0;
            headDebt = 0;
        }

        public void setStudyDebt(double debt)
        {
            studyDebt = debt;
        }

        public void setHeadDebt(double debt)
        {
            headDebt = debt;
        }

        public double getStudyDebt()
        {
            return studyDebt;
        } 
        public double getHeadDebt()
        {
            return headDebt;
        }

    }
}
