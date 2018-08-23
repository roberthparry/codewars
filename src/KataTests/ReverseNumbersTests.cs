using NUnit.Framework;

using Kata;

namespace KataTests
{
	[TestFixture]
    public class ReversedNumbersTests
    {
		private readonly ReverseNumbers _kata = new ReverseNumbers();

		[TestCase(12, 21)]
        [TestCase(321, 123)]
		[TestCase(24767, 76742)]
		[TestCase(-321, -123)]
		[TestCase(-24767, -76742)]
        public void ReverseNumber_ShouldReverseNumber(int number, int reversedNumber)
        {
            Assert.AreEqual(reversedNumber, _kata.ReverseNumber(number));
        }
    }
}

