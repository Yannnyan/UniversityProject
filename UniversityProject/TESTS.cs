using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Data;
using UniversityProject.DAL;
using System.Collections;

namespace UniversityProject
{
    internal class TESTS
    {
        ArrayList objectList;
        DA da;
        TESTS()
        {
            da = new DA();
            objectList = new ArrayList();
        }
        void clearObjects()
        {
            foreach (object obj in objectList)
            {
                da.deleteObject(obj);
            }
            objectList.Clear();
        }
        void addObjects(Object[] objects)
        {
            foreach(Object obj in objects)
            {
                this.objectList.Add(obj);
            }

        }
        //public static void Main()
        //{
        //    TESTS tests = new TESTS();
        //    tests.TestInsertStudent();
        //    tests.TestInsertDebt();
        //    tests.TestInsertGrade();
        //    tests.clearObjects();
        //}


        /* TEST DAL*/

        /* TEST INSERT OBJECT */
        private void TestInsertStudent()
        {
            clearObjects();
            Student[] students = new Student[2];
            students[0] = new Student(0, "person1");
            students[1] = new Student(1, "person2");
            addObjects(students);
            foreach(Student student in students)
            {
                da.insertObject(student);
            }
        }
        private void TestInsertDebt()
        {
            clearObjects();
            Student[] students = new Student[2];
            Debt[] debts = new Debt[4];
            students[0] = new Student(0, "person1");
            students[1] = new Student(1, "person2");
            debts[0] = new Debt(0, students[0].id, 1, "living debt");
            debts[1] = new Debt(1, students[0].id, 2.25, "lying debt");
            debts[2] = new Debt(2, students[1].id,  1, "living debt");
            debts[3] = new Debt(3, students[1].id,  2.25, "lying debt");
            addObjects(debts);
            addObjects(students);
            
            foreach (Student student in students)
            {
                da.insertObject(student);
            }
            foreach (Debt debt in debts)
            {
                da.insertObject(debt);
            }
            
            
        }
        private void TestInsertGrade()
        {
            clearObjects();
            Student[] students = new Student[2];
            Grade[] grades = new Grade[10];
            students[0] = new Student(0, "person1");
            students[1] = new Student(1, "person2");
            for(int i = 0; i < 10; i++)
            {
                if (i < 5)
                    grades[i] = new Grade("xd" + i, i * 10, i, 0);
                else
                {
                    grades[i] = new Grade("xd" + i, i * 10, i, 1);
                }
            }
            addObjects(grades);
            addObjects(students);
            foreach(Student student in students)
            {
                da.insertObject(student);
            }
            foreach(Grade grade in grades)
            {
                da.insertObject(grade);
            }


        }
        /* TEST DELETE OBJECT*/

        private void TestDeleteStudent()
        {

        }
        private void TestDeleteDebt()
        {

        }
        private void TestDeleteGrade()
        {

        }


    }
}
