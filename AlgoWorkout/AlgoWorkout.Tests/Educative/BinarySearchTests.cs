﻿using AlgoWorkout.Educative;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoWorkout.Tests.Educative
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void FindExisting()
        {
            var arr = new int[] { 1, 3, 5, 6, 7, 8, 9, 10, 11, 13 };
            Assert.AreEqual(0, BinarySearch.Search(arr, 1));
            Assert.AreEqual(2, BinarySearch.Search(arr, 5));
            Assert.AreEqual(9, BinarySearch.Search(arr, 13));
        }

        [TestMethod]
        public void NotFoundAbsent()
        {
            var arr = new int[] { 1, 3, 5, 6, 7, 8, 9, 10, 11, 13 };
            Assert.AreEqual(-1, BinarySearch.Search(arr, 2));
            Assert.AreEqual(-1, BinarySearch.Search(arr, 12));
            Assert.AreEqual(-1, BinarySearch.Search(arr, 16));
        }

        [TestMethod]
        public void FindBoundaryNormal()
        {
            var arr = new bool[] { false, false, false, true, true };
            
            Assert.AreEqual(3, BinarySearch.FindBoolBoundary(arr));
        }

        [TestMethod]
        public void FindBoundaryNotfound()
        {
            var arr = new bool[] { false, false, false };

            Assert.AreEqual(-1, BinarySearch.FindBoolBoundary(arr));
        }

        [TestMethod]
        public void FindBoundaryAllTrue()
        {
            var arr = new bool[] { true, true, true };

            Assert.AreEqual(0, BinarySearch.FindBoolBoundary(arr));
        }
    }
}
