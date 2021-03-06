﻿using System;
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
            testlist.Add("Gold");
            testlist.Add("Green");
            string expectedResult = "Gold";
            string ActualResult = testlist[0];
            Assert.AreEqual(expectedResult, ActualResult);

            expectedResult = "Green";
            ActualResult = testlist[1];
            Assert.AreEqual(expectedResult, ActualResult);

            int count = 2;
            int actualCount = testlist.Count;
            Assert.AreEqual(count, actualCount);
        }

        public void addChars()
        {
            CustomList<char> chars = new CustomList<char>();
            chars.Add('a');
            chars.Add('b');
            chars.Add('c');
            chars.Add('d');

            char expectedResult = 'a';
            char ActualResult = chars[0];
            Assert.AreEqual(expectedResult, ActualResult);

            expectedResult = 'b';
            ActualResult = chars[1];
            Assert.AreEqual(expectedResult, ActualResult);

            expectedResult = 'c';
            ActualResult = chars[2];
            Assert.AreEqual(expectedResult, ActualResult);

            expectedResult = 'd';
            ActualResult = chars[3];
            Assert.AreEqual(expectedResult, ActualResult);

            int count = 4;
            int actualCount = chars.Count;
            Assert.AreEqual(count, actualCount);
        }

        public void addChar()
        {
            CustomList<char> letters = new CustomList<char>();
            letters.Add('f');

            char expectedResult = 'f';
            char actualResult = letters[0];
        }

        public void addDouble()
        {
            CustomList<double> Double = new CustomList<double>();
            Double.Add(.5);
            Double.Add(.6);
            Double.Add(.7);

            double expectedResult = .5;
            double ActualResult = Double[0];
            Assert.AreEqual(expectedResult, ActualResult);
        }
    }
}