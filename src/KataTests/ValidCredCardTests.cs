using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class SampleTests
    {
        [Test]
        public void TestCases()
        {
            var _ = new ValidCredCard();
			Assert.AreEqual(false, _.Validate("477 073 360"));
            Assert.AreEqual(true, _.Validate("5422 0148 5514"));
            Assert.AreEqual(true, _.Validate("8314 7046 0245"));
            Assert.AreEqual(false, _.Validate("6654 6310 43044"));
            Assert.AreEqual(true, _.Validate("0768 2757 5685 6340"));
            Assert.AreEqual(false, _.Validate("7164 6207 74042"));
            Assert.AreEqual(true, _.Validate("8383 7332 3570 8514"));
            Assert.AreEqual(true, _.Validate("481 135"));
            Assert.AreEqual(true, _.Validate("355 032 5363"));
        }
    }
}        


