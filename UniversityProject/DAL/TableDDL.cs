using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.DAL
{
    public sealed class TableDDL
    {
        public static bool TableExists(string tableName)
        {
            SqlConnection conn = SingleConnection.createConnection();
            // This block throws exception if a the table parameter does not exist.
            try
            {
                string sqlCommand = "Select * From @table;";
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);
                SqlParameter table = new SqlParameter();
                table.ParameterName = "table";
                table.Value = tableName;
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public static void createTable(string tableName, params string[] parameters)
        {
            // variables
            string name, sqlCommandString;
            SqlConnection conn;
            SqlParameter table;
            SqlParameter[] tableParameters = new SqlParameter[parameters.Length + 1];
            SqlCommand sqlCommand;
            conn = SingleConnection.createConnection();     // get connection
            sqlCommandString = "Create TABLE @table (";     // **create the command string
            table = new SqlParameter();
            table.ParameterName = "table";
            table.Value = tableName;
            tableParameters[0] = table;
            // enters the parameters for the table inside the command string
            for(int i=0; i<parameters.Length; i++)
            {
                name = "param" + i.ToString();
                SqlParameter param = new SqlParameter();
                sqlCommandString += (", @" + name); // add the parameter name
                param.ParameterName = name;
                param.Value = parameters[i];
                tableParameters[i + 1] = param;
            }
            sqlCommandString += ");";
            // adding the parameters into the sql command
            sqlCommand = new SqlCommand(sqlCommandString, conn);
            for(int i=0; i< tableParameters.Length; i++)
            {
                sqlCommand.Parameters.Add(tableParameters[i]);
            }
            sqlCommand.ExecuteNonQuery();       // execute
        }
        

    }
}
