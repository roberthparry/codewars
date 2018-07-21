using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
    public class NextSmallestNumTests
    {
        [TestCase(21, 12)]
        [TestCase(907, 790)]
        [TestCase(531, 513)]
        [TestCase(1027, -1)]
        [TestCase(441, 414)]
        [TestCase(123456798, 123456789)]
        public void FixedTests(long n, long expected)
        {
			Assert.AreEqual(expected, NextSmallestNum.NextSmaller(n));
        }
    }	
}
