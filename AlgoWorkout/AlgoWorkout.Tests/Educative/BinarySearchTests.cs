using AlgoWorkout.Educative;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
