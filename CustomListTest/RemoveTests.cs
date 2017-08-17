using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void removeInts()
        {
            CustomList<int> ints = new CustomList<int>();
            ints.Add(1); // 0
            ints.Add(2); // Value at index 1 Gets Removed
            ints.Add(3); // Value at 2 becomes element at index 1

            ints.Remove(1);
            int actual = ints.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);

            actual = ints[1]; // Should be 3
            Assert.AreNotEqual(expected, actual);
        }

        public void removeStrings()
        {
            CustomList<string> strings = new CustomList<string>();
            strings.Add("a");
            strings.Add("b");
            strings.Remove(0);

            string actual = strings[0];
            string expected = "b";
            Assert.AreEqual(expected, actual);

            int size = strings.Count;
            int eSize = 1;
            Assert.AreEqual(eSize, size);
        }
    }
}