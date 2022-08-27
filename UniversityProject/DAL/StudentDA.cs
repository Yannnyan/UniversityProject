﻿using UniversityProject.Data;
using System.Data.SqlClient;
using System.Data;
using UniversityProject.Debug;
using System.Collections;

namespace UniversityProject.DAL
{
    public class StudentDA
    {
        
        public static void create_table()
        {
            string sql = @"CREATE TABLE [dbo].[Students] (
                            id        INT        NOT NULL,
                            FirstName NCHAR (10) NULL,
                            PRIMARY KEY CLUSTERED (id ASC)
                            );";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        public static void truncate_table()
        {
            string sql = "TRUNCATE TABLE STUDENTS;";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
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
        private static SqlParameter[] getParameters(int studentId, string studentName)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@studentID", SqlDbType.Int);
            parameters[1] = new SqlParameter("@studentName", SqlDbType.VarChar, 10);
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
