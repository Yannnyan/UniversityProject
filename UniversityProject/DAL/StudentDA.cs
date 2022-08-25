using first_project.Data;
using System.Data.SqlClient;
using System.Data;
using UniversityProject.Debug;

namespace UniversityProject.DAL
{
    public class StudentDA
    {
        public static void createStudentTable()
        {
            SqlConnection conn = new SqlConnection(ConnData.conn_string);
            string sql = @"CREATE TABLE Students(
                            id int NOT NULL PRIMARY KEY,
                            FirstName nchar(10) NULL
                            );";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void insertStudent(Student student)
        {
            SqlParameter stid = new SqlParameter("@stID", SqlDbType.Int);
            stid.Value = student.getID();
            SqlParameter stFirstName = new SqlParameter(@"stFirstName", SqlDbType.VarChar, 10);
            stFirstName.Value = student.getName();
            
            string sql = @"INSERT INTO STUDENTS (id, firstName) VALUES (@stID, @stFirstName)";
            
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(stid);
                    cmd.Parameters.Add(stFirstName);
                    int affectedRows = cmd.ExecuteNonQuery();
                    Logger.Log($"Insert Student With Id: {student.getID()}, Rows Affected: " + affectedRows);
                }
            }
       
            
        }
        public static void deleteStudent(int id)
        {
            SqlParameter stid = new SqlParameter("@id", SqlDbType.Int);
            stid.Value = id;
            string sql = @"DELETE FROM STUDENTS WHERE id = @id";
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(stid);
                    Logger.Log($"Delete {id}, Rows affected: " + cmd.ExecuteNonQuery());

                }
            }

        }

    }
}
