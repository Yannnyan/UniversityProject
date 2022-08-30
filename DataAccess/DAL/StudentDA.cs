using Classes.Data;
using System.Data.SqlClient;
using System.Data;
using DataAccess.Debug;
using System.Collections;

namespace DataAccess.DAL
{
    public class StudentDA
    {
       
        
        public static void create_table()
        {
            string sql = @"CREATE TABLE [dbo].[Students] (
                            id        INT        NOT NULL,
                            FirstName NCHAR (10) NULL,
                            Status NCHAR (12) NOT NULL,
                            PRIMARY KEY CLUSTERED (id ASC)
                            );";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        public static void dropTable()
        {
            string sql = @"DROP TABLE Students;";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        public static void truncate_table()
        {
            string sql = @"DELETE FROM TABLENAME
                            DBCC CHECKIDENT('TestUniversity.dbo.Students', RESEED, 0);";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
       
        private static SqlParameter[] getParameters(int studentId, string studentName)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@studentID", SqlDbType.Int);
            parameters[0].Value = studentId;
            parameters[1] = new SqlParameter("@studentName", SqlDbType.VarChar, 10);
            parameters[1].Value = studentName;
            return parameters;
        }
        public static void insertStudent(int studentID, string studentName)
        {
            SqlParameter[] parameters = getParameters(studentID, studentName);
            string sql = @"INSERT INTO STUDENTS (id, firstName) VALUES (@studentID, @studentName);";

            DAManagement.execNonQ(sql, parameters);
        }
        public static void deleteStudent(int studentID)
        {
            SqlParameter stid = new SqlParameter("@id", SqlDbType.Int);
            stid.Value = studentID;
            string sql = @"DELETE FROM STUDENTS WHERE id = @id;";
            DAManagement.execNonQ(sql, new SqlParameter[] { stid });

        }
        public static void updateStudent(int studentID, string studentName)
        {
            SqlParameter[] parameters = getParameters(studentID, studentName);
            string sql = @"UPDATE STUDENTS 
                            SET studentName = @studentName
                            WHERE studentID = @studentID;";
            DAManagement.execNonQ(sql, parameters);
        }
        private static Student build_student(SqlDataReader reader)
        {
            int studentID = (int)reader["studentID"];
            string studentName = (string)reader["firstName"];
            ArrayList grades = GradesDA.getAllGrades(studentID);
            ArrayList debts = DebtsDA.getAllDebts(studentID);
            return new Student(studentID, studentName, grades, debts);

        }
        public static Student getStudent(int studentID)
        {
            // get the student name
            SqlParameter stID = new SqlParameter("@studentID", SqlDbType.Int);
            stID.Value = studentID;
            string sql = @"SELECT * FROM STUDENTS 
                            WHERE STUDENTID = @studentID;";
            SqlDataReader reader = DAManagement.execQ(sql, new SqlParameter[] { stID });
            Student student = build_student(reader);
            reader.Close();
            return student;
        }


    }
}
