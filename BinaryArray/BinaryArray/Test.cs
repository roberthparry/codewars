namespace Solution
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class SolutionTest
    {
		[TestCase(0, new int[] { 0, 0, 0, 0 })]
		[TestCase(15, new int[] { 1, 1, 1, 1 })]
		[TestCase(6, new int[] { 0, 1, 1, 0 })]
		[TestCase(5, new int[] { 0, 1, 0, 1 })]
		[TestCase(21, new int[] { 1, 0, 1, 0, 1 })]
        public void BasicTesting(int result, int[] array)
        {
            Assert.AreEqual(result, Kata.binaryArrayToNumber(array));
        }
    }
}