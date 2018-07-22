using NUnit.Framework;
using Kata;

namespace KataTests
{
	[TestFixture]
    public class HammingNumbersTests
    {

		[TestCase(1, 1)]
		[TestCase(2, 2)]
		[TestCase(3, 3)]
		[TestCase(4, 4)]
		[TestCase(5, 5)]
		[TestCase(6, 6)]
		[TestCase(8, 7)]
		[TestCase(9, 8)]
		[TestCase(10, 9)]
		[TestCase(12, 10)]
		[TestCase(15, 11)]
		[TestCase(16, 12)]
		[TestCase(18, 13)]
		[TestCase(20, 14)]
		[TestCase(24, 15)]
		[TestCase(25, 16)]
		[TestCase(27, 17)]
		[TestCase(30, 18)]
		[TestCase(32, 19)]
        public void HammingNumbers_Test(long expected, int n)
        {
			Assert.AreEqual(expected, HammingNumbers.Hamming(n), $"Hamming({n}) should be {expected}");
        }
    }	
}
