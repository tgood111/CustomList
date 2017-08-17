using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddTests
    {
        // Checking the size of the array.
        // Checking individual elements
        [TestMethod]
        public void addNumbers()
        {
            CustomList<int> testlist = new CustomList<int>();
            testlist.Add(2);
            testlist.Add(4);
            int expectedResult = 4;
            int ActualResult = testlist[1];
            Assert.AreEqual(expectedResult, ActualResult);
            expectedResult = 2;
            ActualResult = testlist[0];
            Assert.AreEqual(expectedResult, ActualResult);
            ActualResult = testlist.Count; // Should be 2
            Assert.AreEqual(expectedResult, ActualResult);
        }

        [TestMethod]
        public void addStrings()
        {
            CustomList<string> testlist = new CustomList<string>();
            testlist.Add("Purple");
            testlist.Add("Green");
            string expectedResult = "Purple";
            string ActualResult = testlist[0];
            Assert.AreEqual(expectedResult, ActualResult);

            expectedResult = "Green";
            ActualResult = testlist[1];
            Assert.AreEqual(expectedResult, ActualResult);

            int count = 2;
            int actualCount = testlist.Count;
            Assert.AreEqual(count, actualCount);
        }
    }
}