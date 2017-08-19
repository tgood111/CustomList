using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class SubtractionTest
    {

        [TestMethod]
        public void TestSubtraction()
        {
            CustomList<int> a = new CustomList<int>();
            a.Add(1);
            a.Add(2);
            CustomList<int> b = new CustomList<int>();
            b.Add(2);

            CustomList<int> c = a - b;
            Assert.AreEqual(1, c.Count);
        }
    }
}