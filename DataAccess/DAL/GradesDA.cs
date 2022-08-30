using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Data;
using System.Data;
using System.Collections;

namespace UniversityProject.DAL
{
    public class GradesDA
    {
        public static void create_table()
        {
            string sql = @"CREATE TABLE [dbo].[Grades] (
                            gradeID    INT          NOT NULL,
                            studentID  INT          NOT NULL,
                            courseName VARCHAR (15) NOT NULL,
                            grade      INT          NOT NULL,
                            PRIMARY KEY CLUSTERED (gradeID ASC),
                            FOREIGN KEY (studentID) REFERENCES [dbo].[Students] (id),
                            CHECK (grade>=(0) AND grade<=(100))
                        );
                        ";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        public static void truncate_table()
        {
            string sql = "TRUNCATE TABLE GRADES;";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        private static SqlParameter[] getParameters(int gradeID, string courseName, int studentID, int grade)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@gradeID", SqlDbType.Int);
            parameters[0].Value = gradeID;
            parameters[1] = new SqlParameter("@courseName", SqlDbType.VarChar, 15);
            parameters[1].Value = courseName;
            parameters[2] = new SqlParameter("@studentID", SqlDbType.Int);
            parameters[2].Value = studentID;
            parameters[3] = new SqlParameter("@grade", SqlDbType.Int);
            parameters[3].Value = grade;
            return parameters;
        }

        public static void insertGrade(int gradeID, string courseName, int studentID, int grade)
        {
            SqlParameter[] parameters = getParameters(gradeID, courseName, studentID, grade);
            string sql = "INSERT INTO Grades(studentID, courseName, grade, gradeID) " +
                        "VALUES (@studentID, @courseName, @grade, @gradeID)";
            DAManagement.execNonQ(sql, parameters);

        }
        public static void deleteGrade(int gradeID)
        {
            SqlParameter gradeIDParam = new SqlParameter("@gradeID", SqlDbType.Int);
            gradeIDParam.Value = gradeID;
            string sql = @"DELETE FROM GRADES WHERE GRADEID = @gradeID;";
            DAManagement.execNonQ(sql, new SqlParameter[] {gradeIDParam});
        }
        public static void updateGrade(int gradeID, string courseName, int studentID, int grade)
        {
            SqlParameter[] parameters = getParameters(gradeID, courseName, studentID, grade);
            string sql = @"UPDATE GRADES
                            SET COURSENAME = @courseName, STUDENTID = @studentID, GRADE = @grade
                            WHERE GRADEID = @gradeID";
            DAManagement.execNonQ(sql, parameters);
        }
        private static Grade build_grade(SqlDataReader reader)
        {
            object[] arr = new object[4];
            arr[0] = reader["gradeID"];
            arr[1] = reader["courseName"];
            arr[2] = reader["studentID"];
            arr[3] = reader["grade"];
            return new Grade((string)arr[1], (int)arr[3], (int)arr[0], (int)arr[2]);
        }
        public static Grade getGrade(int gradeID)
        {
            SqlParameter gID = new SqlParameter("@gradeID", SqlDbType.Int);
            gID.Value = gradeID;
            string sql = @"SELECT * FROM GRADES
                            WHERE GRADEID = @gradeID";
            SqlDataReader reader = DAManagement.execQ(sql, new SqlParameter[] {gID});
            Grade grade = build_grade(reader);
            reader.Close();
            return grade;
        }
        public static ArrayList getAllGrades(int studentID)
        {
            SqlParameter sID = new SqlParameter("@studentID", SqlDbType.Int);
            sID.Value = studentID;
            string sql = @"SELECT * FROM GRADES
                            WHERE STUDENTID = @studentID";
            SqlDataReader reader = DAManagement.execQ(sql, new SqlParameter[] { sID });
            ArrayList grades = new ArrayList();
            while (reader.Read())
            {
                grades.Add(build_grade(reader));
            }
            reader.Close();
            return grades;
        }
    }
}
