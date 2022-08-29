using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.DAL
{
    public interface DAInterface
    {
      
         /// This function inserts an object to a table by the parameters given.
        public void insertObject(Object obj);
        /**
         * This function deletes an object from a table by the parameters given
         */
        public void deleteObject(Object obj);
        /**
         * This function updates an object in a table by the parameters given
         */
        public void updateObject(Object obj);
        /**
         * This function returns an from a table object by the parameters given
         */
        public Object getObject(int primaryKey, string tableName);
        /** This function creates a new database */
        public void createDB(string name);
    }
}
