using first_project.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.DAL;

namespace first_project.DAL
{
    internal class StudentDA
    {
        SqlConnection conn = null;
        public StudentDA ()
        {
            conn = SingleConnection.createConnection();
        }

        public void insertStudent(Student student)
        {
            
            if(!TableDDL.TableExists("Students"))
            {
                TableDDL.createTable("Students");
            }
            /**  Entering the details into the Students table **/
            try
            {
                string commandString = "Insert into Students (id, Name)" +
                "Values (@id, @name);";
                // defining parameters
                SqlCommand cmd = new SqlCommand(commandString, conn);
                SqlParameter name = new SqlParameter();
                SqlParameter id = new SqlParameter();
                id.ParameterName = "id";
                id.Value = student.getID();
                name.ParameterName = "name";
                name.Value = student.getName();
                cmd.Parameters.Add(id); // adding
                cmd.Parameters.Add(name);
                // exec
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                throw (new InvalidDataException("failed inserting into students"));
            }
        }
        public void deleteStudent(int id)
        {
            try
            {
                string sqlString = "Delete From Students where id = @id;";
                
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "id";
                param.Value = id;
                cmd.Parameters.Add(param);
                // exec
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw (new InvalidDataException("Student id does not exist"));
            }

        }

    }
}
