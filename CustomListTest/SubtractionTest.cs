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
        [TestMethod]
        public void TSubtraction()
        {
            CustomList<int> d = new CustomList<int>();
            d.Add(3);
            d.Add(4);
            CustomList<int> e = new CustomList<int>();
            e.Add(4);

            CustomList<int> f = d - e;
            Assert.AreEqual(1, f.Count);
        }
        [TestMethod]
        public void SubtractStrings()
        {
            CustomList<string> g = new CustomList<string>();
            g.Add("Green");
            g.Add("Gold");

            CustomList<string> h = new CustomList<string>();
            h.Add("Superbowl");

            CustomList<string> i = g - h;
            Assert.AreEqual(1, i.Count);

            
        }
    }
}