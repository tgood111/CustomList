using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void IntToString()
        {
            CustomList<int> ints = new CustomList<int>();
            ints.Add(2);
            ints.Add(4);

            string result = ints.ToString(); // "[2,4]"
            string expected = "[2,4]";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CharListToString()
        {
            CustomList<char> chars = new CustomList<char>();
            chars.Add('a');
            chars.Add('b');
            chars.Add('c');
            chars.Add('d');

            string result = chars.ToString(); // "[a,b,c,d]"
            string expected = "[a,b,c,d]";
            Assert.AreEqual(expected, result);
        }
    }
}