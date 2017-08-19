using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    class OperatorTest
    {
        [TestMethod]
        public void TestAddittion()
        {
            CustomList<int> a = new CustomList<int>();
            a.Add(1);
            CustomList<int> b = new CustomList<int>();
            b.Add(2);

            CustomList<int> c = a + b;
            Assert.AreEqual(1, c[0]);
            Assert.AreEqual(2, c[1]);
        }
    }
}
