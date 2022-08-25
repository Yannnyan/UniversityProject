using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using first_project.Data;
using UniversityProject.Debug;


namespace UniversityProject.DAL
{
    public class DebtsDA
    {
        public static void insertDebt(int transactionID, int studentID, double amount, string description)
        {
            SqlParameter stID = new SqlParameter("@studentID", SqlDbType.Int);
            stID.Value = studentID;
            SqlParameter a = new SqlParameter("@amount", SqlDbType.Float);
            a.Value = amount;
            SqlParameter desc = new SqlParameter("@descrip", SqlDbType.VarChar, 50);
            desc.Value = description;
            SqlParameter transact = new SqlParameter("@transactionID", SqlDbType.Int);
            transact.Value = transactionID;
            string sql = @"INSERT INTO DEBTS (transactionID, studentID, amount, detail) 
                            VALUES (@transactionID, @studentId, @amount, @descrip)";
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(stID);
                    cmd.Parameters.Add(a);
                    cmd.Parameters.Add(desc);
                    cmd.Parameters.Add(transact);
                    Logger.Log($"Insert Debt With Transaction ID = {transactionID}, Number Of Rows Affected: " + cmd.ExecuteNonQuery());
                }
            }
        }
        public static void deleteDebt(int transactionID)
        {
            SqlParameter transac = new SqlParameter("@transactionID", SqlDbType.Int);
            transac.Value = transactionID;
            string sql = @"DELETE FROM DEBTS WHERE TRANSACTIONID = @transactionID";
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(transac);
                    Logger.Log($"Delete Debt With Transaction Id = {transactionID}, Number Of Rows Affected: " + cmd.ExecuteNonQuery());
                }
            }
        }
    }
}
