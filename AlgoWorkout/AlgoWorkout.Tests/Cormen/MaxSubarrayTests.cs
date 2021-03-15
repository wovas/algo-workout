using AlgoWorkout.Cormen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoWorkout.Tests.Cormen
{
    [TestClass]
    public class MaxSubarrayTests
    {
        public static MaxSubarray sut = new MaxSubarray();

        [TestMethod]
        public void TestNaiveImplementation()
        {
            var input = new int[] { 10, 11, 7, 10, 6 };
            int maxOutcome = 3;

            int result = sut.BruteForce(input);

            Assert.AreEqual(maxOutcome, result);
        }

        [TestMethod]
        public void TestNaiveImplementationLong()
        {
            var input = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int maxOutcome = 106 - 63;

            int result = sut.BruteForce(input);

            Assert.AreEqual(maxOutcome, result);
        }
    }
}
