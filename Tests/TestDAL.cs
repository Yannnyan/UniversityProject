namespace Tests
{
    [TestClass]
    public class TestDAL
    {
        [AssemblyInitialize]
        public static void AssemblyInit()
        {
            DA da = new DA();
            da.createDB("TestUniversity");
            StudentDA.createStudentTable();
            DebtsDA.create_table();
            GradesDA.create_table();
        }
        /*object Insertion tests*/
        /* Test StudentDA */
        [TestMethod]
        public void TestInsertStudent()
        {
            StudentDA.truncate_table();
            Student st1 = new Student(1, "Haim");
            DA da = new DA();
            try
            {
                da.insertObject(st1);
            }
            catch(Exception e)
            {
                
                AssertFailedException exdp = new AssertFailedException("Failed to insert student", e);
                return;
            }

        }
        [TestMethod]
        public void TestInsertDebt()
        {
            DebtsDA.truncate_table();
            StudentDA.truncate_table();
            Student student = new Student(0, "person1");
            Student student1 = new Student(1, "person2");
            Debt debt1 = new Debt(0, student.id, 1, "living debt");
            Debt debt2 = new Debt(1, student.id, 2.25, "lying debt");
            Debt debt3 = new Debt(2, student1.id, 1, "living debt");
            Debt debt4 = new Debt(3, student1.id, 2.25, "lying debt");
            DA da = new DA();
            
            da.insertObject(student);
            da.insertObject(debt1);
            da.insertObject(debt2);
            da.insertObject(student1);
            da.insertObject(debt3);
            da.insertObject(debt4);



        }
        [TestMethod]
        public void TestInsertGrade()
        {
            GradesDA.truncate_table();

        }

        /*object Deletion tests*/
        [TestMethod]
        public void TestDeleteStudent()
        {
           

        }
        [TestMethod]
        public void TestDeleteDebt()
        {

        }
        [TestMethod]
        public void TestDeleteGrade()
        {

        }
        /*object update tests*/
        public void TestUpdateStudent()
        {


        }
        [TestMethod]
        public void TestUpdateDebt()
        {

        }
        [TestMethod]
        public void TestUpdateGrade()
        {

        }
        /*object queries tests*/
        [TestMethod]
        public void TestGetGrade()
        {

        }
        [TestMethod]

        public void TestGetDebt()
        {

        }
        [TestMethod]

        public void TestGetAllGrades()
        {

        }
        [TestMethod]

        public void TestGetAllDebts()
        {

        }
        [TestMethod]

        public void TestGetStudent()
        {

        }
        [TestMethod]

        public void TestGetAllStudents()
        {

        }
    }
}