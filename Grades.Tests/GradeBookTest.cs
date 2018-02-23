using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;
namespace Grades.Tests
{
    [TestClass]
   public class GradeBookTest
    {
        [TestMethod]
        public void ComputeHighestValue()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(40);
            book.AddGrade(50);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(50, result.HighestGrade);
        }
        [TestMethod]
        public void ComputeLowestValue()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(40);
            book.AddGrade(50);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(40, result.lowestGrade);
        }
        public void ComputeAveraageValue()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(40);
            book.AddGrade(50);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(45, result.AverageGrade);
        }
    }

}
