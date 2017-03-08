using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Grades.test
{
    [TestClass]
   public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(33);
            book.AddGrade(87);
            book.AddGrade(66);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(91, result.HighestGrade);
        
        }
        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(33);
            book.AddGrade(87);
            book.AddGrade(66);
            book.AddGrade(75);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(33, result.LowestGrade);
        }
        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(33);
            book.AddGrade(87);
            book.AddGrade(66);
            book.AddGrade(75);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(70.4, result.AverageGrade, 0.1);
        }
    }
}
