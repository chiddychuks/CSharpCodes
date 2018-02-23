using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace Grades.Tests.Types
{
    //this is a test for reference types
    [TestClass]
   public class ReferenceTypesTests
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

           // g1 = new Gradebook();
            g1.Name = "This is Chidi learning CSharp";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        //this is a test for value types
        [TestMethod]
        public void IntVaraiblesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "chidi";
            string nam2 = "Chidi";
            bool result = string.Equals(name1, nam2);
            Assert.IsFalse(result);
        }

        //checking of parameter passed by reference
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveABookAName(book2);
            Assert.AreEqual("Mastery of CSharp", book1.Name);
            //this assertion is supposed to be true and asserts false...need help!!!
        }


        private void GiveABookAName(Gradebook bk)
        {
            bk.Name = "Mastery of CSharp";
        }


        //checking of parameter passed by value
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 5;
            IncrementNumber(x);
            Assert.AreEqual(5, x);
        }

        private void IncrementNumber(int num)
        {
            num += 1;
        }

        //test to show that datetime is value type
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018,2,20);
            //date.AddDays(1);//this test will fail because datetime is a value type and not a ref type
            date = date.AddDays(1);
            Assert.AreEqual(21, date.Day);
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "chidi";
            //name.ToUpper();
//this is to show that string which is a ref type behaves like a value type because some methods inside its class returns values
           
            name = name.ToUpper();

            Assert.AreEqual("CHIDI",name);
        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }
    }
}
