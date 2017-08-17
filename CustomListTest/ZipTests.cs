using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void IntZipTest()
        {
            CustomList<int> ints = new CustomList<int>();
            ints.Add(1);
            ints.Add(3);
            ints.Add(5);

            CustomList<int> ints2 = new CustomList<int>();
            ints2.Add(2);
            ints2.Add(4);
            ints2.Add(6);

            // This function should zip the second CustomList into the first CustomList
            ints.Zip(ints2); // The first list should now look like: [1,2,3,4,5,6]

            // Check if i'th element equals (i+1)
            for (int i = 0; i < 6; ++i)
            {
                Assert.AreEqual(i + 1, ints[i]);
            }
        }

        [TestMethod]
        public void CharsZipTest()
        {
            CustomList<char> chars = new CustomList<char>();
            chars.Add('a');
            chars.Add('c');
            chars.Add('e');

            CustomList<char> chars2 = new CustomList<char>();
            chars2.Add('b');
            chars2.Add('d');
            chars2.Add('f');

            chars.Zip(chars2); // [a,b,c,d,e,f]

            Assert.AreEqual('a', chars[0]);
            Assert.AreEqual('b', chars[1]);
            Assert.AreEqual('c', chars[2]);
            Assert.AreEqual('d', chars[3]);
            Assert.AreEqual('e', chars[4]);
            Assert.AreEqual('f', chars[5]);
        }

        [TestMethod]
        public void StringZipTest()
        {
            CustomList<string> strings1 = new CustomList<string>();
            strings1.Add("a");
            strings1.Add("c");
            strings1.Add("e");

            CustomList<string> strings2 = new CustomList<string>();
            strings2.Add("b");
            strings2.Add("d");
            strings2.Add("f");

            strings1.Zip(strings2); // [a,b,c,d,e,f]

            Assert.AreEqual("a", strings1[0]);
            Assert.AreEqual("b", strings1[1]);
            Assert.AreEqual("c", strings1[2]);
            Assert.AreEqual("d", strings1[3]);
            Assert.AreEqual("e", strings1[4]);
            Assert.AreEqual("f", strings1[5]);
        }
    }
}