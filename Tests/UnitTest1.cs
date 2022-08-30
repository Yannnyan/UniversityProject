using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess.DAL;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StudentDA.dropTable();
            StudentDA.create_table();
        }
    }
}