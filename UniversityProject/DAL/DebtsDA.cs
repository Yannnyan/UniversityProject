using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using UniversityProject.Data;
using UniversityProject.Debug;
using System.Collections;

namespace UniversityProject.DAL
{
    public class DebtsDA
    {
        public static void create_table()
        {
            string sql = @"CREATE TABLE [dbo].[Debts] (
                            transactionID INT NOT NULL,
                            studentID INT NULL,
                            amount        FLOAT(53)   NULL,
                            detail VARCHAR(50) NULL,
                            PRIMARY KEY CLUSTERED(transactionID ASC),
                            FOREIGN KEY(studentID) REFERENCES[dbo].[Students]([id])
                        ); ";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        public static void truncate_table()
        {
            string sql = "TRUNCATE TABLE DEBTS;";
            DAManagement.execNonQ(sql, new SqlParameter[] { });
        }
        private static SqlParameter[] getParameters(int transactionID, int studentID, double amount, string description)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@transactionID", SqlDbType.Int);
            parameters[0].Value = transactionID;
            parameters[1] = new SqlParameter("@amount", SqlDbType.Float);
            parameters[1].Value = amount;
            parameters[2] = new SqlParameter("@studentID", SqlDbType.Int);
            parameters[2].Value = studentID;
            parameters[3] = new SqlParameter("@detail", SqlDbType.VarChar, 50);
            parameters[3].Value = description;
            return parameters;
        }
        public static void insertDebt(int transactionID, int studentID, double amount, string description)
        {
            SqlParameter[] parameters = getParameters(transactionID, studentID, amount, description);

            string sql = @"INSERT INTO DEBTS (transactionID, studentID, amount, detail) 
                            VALUES (@transactionID, @studentId, @amount, @detail)";
            DAManagement.execNonQ(sql, parameters);
        }
        public static void deleteDebt(int transactionID)
        {
            SqlParameter transac = new SqlParameter("@transactionID", SqlDbType.Int);
            transac.Value = transactionID;
            string sql = @"DELETE FROM DEBTS WHERE TRANSACTIONID = @transactionID";
            DAManagement.execNonQ(sql, new SqlParameter[] { transac });
        }
        private static Debt build_debt(SqlDataReader reader)
        {
            object[] arr = new object[reader.FieldCount];
            arr[0] = reader["transactionID"];
            arr[1] = reader["studentID"];
            arr[2] = reader["amount"];
            arr[3] = reader["detail"];
            return new Debt((int)arr[0], (int)arr[1], (double)arr[2], (string)arr[3]);
        }
        public static Debt getDebt(int transactionID)
        {
            SqlParameter transID = new SqlParameter("@transactionID", SqlDbType.Int);
            transID.Value = transactionID;
            string sql = @"SELECT * FROM DEBTS 
                            WHERE TRANSACTIONID = @transactionID;";
            SqlDataReader reader = DAManagement.execQ(sql, new SqlParameter[] { transID });
            Debt debt = build_debt(reader);
            reader.Close();
            return debt;
        }
        public static void updateDebt(int transactionID, int studentID, double amount, string description)
        {
            SqlParameter[] parameters = getParameters(transactionID, studentID, amount, description);
            string sql = @"UPDATE DEBTS
                            SET amount = @amount, studentID = @studentID, detail = @detail
                            WHERE transactionID = @transactionID;";
            DAManagement.execNonQ(sql, parameters);
        }
        public static ArrayList getAllDebts(int studentID)
        {
            SqlParameter sID = new SqlParameter("@studentID", SqlDbType.Int);
            sID.Value = studentID;
            string sql = @"SELECT * FROM DEBTS
                            WHERE STUDENTID = @studentID";
            SqlDataReader reader = DAManagement.execQ(sql, new SqlParameter[]{ sID });
            ArrayList debts = new ArrayList();
            while(reader.Read())
            {
                debts.Add(build_debt(reader));
            }
            reader.Close();
            return debts;
        }
    }
}
