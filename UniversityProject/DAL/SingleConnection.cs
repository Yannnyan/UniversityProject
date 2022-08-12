using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.DAL
{
    public sealed class SingleConnection
    {
        /** NOT THREAD SAFE */
        /*. 
                         _ 
 . ... .-',     ..(`)) 
'-. `     '  /-._.-'    ',/ 
   )         \            '. 
  / _    _    |             \ 
 |  a    a    /              | 
 \   .-.                     ;   
  '-('' ).-'       ,'       ; 
     '-;           |      .' 
        \           \    / 
        | 7  .__  _.-\   \ 
        | |  |  ``/  /`  / 
       /,|  |   /,/   / 
          /,_/      '`-'
         * 
         */
        private static SingleConnection singleConnection = null;
        private static SqlConnection sqlConnection = null;
        private SingleConnection()
        {
        }
        public static SqlConnection createConnection()
        {
            if (sqlConnection == null)
            {
                singleConnection = new SingleConnection();
                string connectionString = @"Server=localhost\MSSQLSERVER01;Database=master;Trusted_Connection=True;";
                sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
            }
            return sqlConnection;
        }
    }
}
