using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_project.Data;
using System.Data;
using UniversityProject.Debug;

namespace UniversityProject.DAL
{
    public class GradesDA
    {
        public static void insertGrade(string courseName, int studentID, int grade)
        {
            SqlParameter cName = new SqlParameter("@courseName", SqlDbType.VarChar, 15);
            cName.Value = courseName;
            SqlParameter stID = new SqlParameter("@stID", SqlDbType.Int);
            stID.Value = studentID;
            SqlParameter g = new SqlParameter("@grade", SqlDbType.Int);
            g.Value = grade;
            string sql = "INSERT INTO Grades(studentID, courseName, grade) VALUES (@stID, @courseName, @grade)";
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(cName);
                    cmd.Parameters.Add(stID);
                    cmd.Parameters.Add(g);
                    Logger.Log($"Insert grade With stID: {studentID}, Affected Rows: " + cmd.ExecuteNonQuery());
                }
            }

        }
        public static void deleteGrade(int studentID, string courseName)
        {
            SqlParameter cName = new SqlParameter("@courseName", SqlDbType.VarChar, 15);
            cName.Value = courseName;
            SqlParameter stID = new SqlParameter("@studentID", SqlDbType.Int);
            stID.Value = studentID;
            string sql = @"DELETE FROM GRADES WHERE COURSENAME = @courseName AND STUDENTID = @studentID";
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(stID);
                    cmd.Parameters.Add(cName);
                    Logger.Log($"Delete Grade With Id And Course: {studentID} {courseName}, " +
                        $"Number Of Rows Affected: " + cmd.ExecuteNonQuery());
                }
            }
        }
    }
}
