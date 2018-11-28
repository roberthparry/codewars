using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class CountPosSumNegTests
    {
        [Test]
        public void CountPositivesSumNegatives_BasicTest()
        {
            int[] expectedResult = new int[] { 10, -65 };

            Assert.AreEqual(expectedResult, CountPosSumNeg.CountPositivesSumNegatives(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }));
        }

        [Test]
        public void CountPositivesSumNegatives_InputWithZeroes()
        {
            int[] expectedResult = new int[] { 8, -50 };

            Assert.AreEqual(expectedResult, CountPosSumNeg.CountPositivesSumNegatives(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 }));
        }
    }
}
