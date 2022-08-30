using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Classes.Data;
using UniversityProject.Debug;

namespace UniversityProject.DAL
{
    public class DAManagement
    {

        /**
         * This function adds parameters to the sql command, and execute non query
         */
        public static void execNonQ(string sql, SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    for(int i = 0; i < sqlParameters.Length; i++)
                    {
                        cmd.Parameters.Add(sqlParameters[i]);
                    }
                    int rows_affected = cmd.ExecuteNonQuery();
                    StringBuilder log = new StringBuilder($"Execute non query with parameters: ");
                    foreach (SqlParameter param in sqlParameters)
                    {
                        log.Append(" " + param.ParameterName);
                    }
                    log.Append($" Number of rows affected: {rows_affected}");
                    Logger.Log(log.ToString());
                }
            }
        }
        public static SqlDataReader execQ(string sql, SqlParameter[] sqlParameters)
        {

            using (SqlConnection conn = new SqlConnection(ConnData.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    for (int i = 0; i < sqlParameters.Length; i++)
                    {
                        cmd.Parameters.Add(sqlParameters[i]);
                    }
                    SqlDataReader execReader = cmd.ExecuteReader();
                    return execReader;
                }
            }
        }

    }
}
