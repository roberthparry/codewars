using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class IntegerSquareRootTests
    {
        [TestCase(3, new int[] { 1, 2 })]
        [TestCase(4, 2)]
        [TestCase(10, new int[] { 3, 4 })]
        [TestCase(16, 4)]
        [TestCase(25, 5)]
        [TestCase(30, new int[] { 5, 6 })]
        [TestCase(40, new int[] { 6, 7 })]
        [TestCase(625, 25)]
        [TestCase(626, new int[] { 25, 26 })]
        [TestCase(624, new int[] { 24, 25 })]
        public void IntegerSqrt_Test(int number, object expected)
        {
            Assert.AreEqual(expected, IntegerSquareRoot.SqrtApproximation(number));
        }
    }
}
