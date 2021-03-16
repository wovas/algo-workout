using AlgoWorkout.Cormen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgoWorkout.Tests.Cormen
{
    [TestClass]
    public class MaxSubarrayTests
    {
        private const int LongArraySize = 20_000;
        public static MaxSubarray sut = new MaxSubarray();
        public static int[] LongArray = new int[LongArraySize];

        [ClassInitialize]
        public static void Init(TestContext context) 
        {
            Random rand = new Random(13);
            int initialPrice = 100;
            LongArray[0] = initialPrice;
            for (int i = 1; i < LongArraySize; i++)
            {
                int delta = rand.Next(-50, 50);
                LongArray[i] = LongArray[i - 1] + delta;
            }
        }

        [TestMethod]
        public void TestNaiveImplementation()
        {
            var input = new int[] { 10, 11, 7, 10, 6 };
            int maxOutcome = 3;

            int result = sut.BruteForce(input);

            Assert.AreEqual(maxOutcome, result);
        }

        [TestMethod]
        public void TestNaiveImplementationStockArray()
        {
            var input = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int maxOutcome = 106 - 63;

            int result = sut.BruteForce(input);

            Assert.AreEqual(maxOutcome, result);
        }

        [TestMethod]
        public void TestNaiveImplementationOnLongArray()
        {
            var input = LongArray;
            
            int result = sut.BruteForce(input);

            Assert.AreEqual(4621, result);
        }

        [TestMethod]
        public void TestDivideAndConquerImplementation()
        {
            var input = new int[] { 10, 11, 7, 10, 6 };
            int maxOutcome = 3;

            int result = sut.DivideAndConquer(input);

            Assert.AreEqual(maxOutcome, result);
        }

        [TestMethod]
        public void TestDivideAndConquerImplementationOnLongArray()
        {
            var input = LongArray;

            int result = sut.DivideAndConquer(input);

            Assert.AreEqual(4621, result);
        }

        [TestMethod]
        public void TestDivideAndConquerImplementationStockArray()
        {
            var input = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int maxOutcome = 106 - 63;

            int result = sut.DivideAndConquer(input);

            Assert.AreEqual(maxOutcome, result);
        }
    }
}
