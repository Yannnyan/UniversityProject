using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Data;

namespace DataAccess.DAL
{
    /**
     * This class is a proxy for the Data Access layer
     */
    public class DA : DAInterface
    {
       
        public static void createDB(string name)
        {
            DBDA.createDB(name);
        }
        
        public static void deleteObject(object obj)
        {
            if (obj is Student)
            {
                Student student = (Student)obj;
                StudentDA.deleteStudent(student.id);
            }
            else if (obj is Debt)
            {
                Debt debt = (Debt)obj;
                DebtsDA.deleteDebt(debt.debtID);
            }
            else if (obj is Grade)
            {
                Grade grade = (Grade)obj;
                GradesDA.deleteGrade(grade.gradeID);
            }
        }

        public static object getObject(int primaryKey, string tableName)
        {
            throw new NotImplementedException();
        }

        public static void insertObject(object obj)
        {
            if (obj is Student)
            {
                Student std = (Student)obj;
                StudentDA.insertStudent(std.id, std.name);
            }
            else if (obj is Debt)
            {
                Debt debt = (Debt)obj;
                DebtsDA.insertDebt(debt.debtID, debt.studentID, debt.amount, debt.description);
            
            }
            else if (obj is Grade)
            {
                Grade grade = (Grade)obj;
                GradesDA.insertGrade(grade.gradeID, grade.courseName, grade.studentID, grade.grade);

            }
        }

        public static void updateObject(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
