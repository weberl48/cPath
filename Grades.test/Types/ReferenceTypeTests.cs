using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.test.Types
{

    [TestClass]
    class ReferenceTypeTests
    {

        [TestMethod]
        public void StringComparisons() {
            string name1 = "Bob";
            string name2 = "bob";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
            }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void GradebookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Bob's gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
