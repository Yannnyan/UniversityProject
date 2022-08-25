namespace Tests
{
    using first_project.DAL;
    using first_project.Data;
    [TestClass]
    public class TestDAL
    {
        /* Test StudentDA */
        [TestMethod]
        public void TestInsertStudent()
        {
            Student st1 = new Student(1, "Haim");
            StudentDA stDA = new StudentDA();
            stDA.insertStudent(st1);

        }
    }
}