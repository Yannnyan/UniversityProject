using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public  interface DAInterface
    {
      
         /// This function inserts an object to a table by the parameters given.
        public static void insertObject(Object obj) => throw new NotImplementedException();
        /**
         * This function deletes an object from a table by the parameters given
         */
        public static void deleteObject(Object obj) => throw new NotImplementedException();
        /**
         * This function updates an object in a table by the parameters given
         */
        public static void updateObject(Object obj) => throw new NotImplementedException();
        /**
         * This function returns an from a table object by the parameters given
         */
        public static Object getObject(int primaryKey, string tableName) => throw new NotImplementedException();
    }
}
