using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class BinaryArrayTests
    {
		[TestCase(0, new int[] { 0, 0, 0, 0 })]
		[TestCase(15, new int[] { 1, 1, 1, 1 })]
		[TestCase(6, new int[] { 0, 1, 1, 0 })]
		[TestCase(5, new int[] { 0, 1, 0, 1 })]
		[TestCase(21, new int[] { 1, 0, 1, 0, 1 })]
        public void BasicTesting(int result, int[] array)
        {
            Assert.AreEqual(result, BinaryArray.binaryArrayToNumber(array));
        }
    }
}