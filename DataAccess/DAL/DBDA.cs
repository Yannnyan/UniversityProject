using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess.DAL
{
    internal class DBDA
    {
        public static void createDB(string dbName)
        {
            SqlParameter name = new SqlParameter("@dbName", SqlDbType.VarChar, 12);
            name.Value = dbName;
            string sql = @"DROP DATABASE IF EXISTS @dbName;
                            CREATE DATABASE @name;";
            DAManagement.execNonQ(sql, new SqlParameter[] { name });
        }
    }
}
