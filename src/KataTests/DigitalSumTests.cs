using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class DigitalSumTests
    {
        private DigitalSum num;

        [SetUp]
        public void SetUp()
        {
            num = new DigitalSum();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [TestCase(0, 0)]
        [TestCase(16, 7)]
        [TestCase(456, 6)]
        [TestCase(123456, 3)]
        [TestCase(123456789, 9)]
        [TestCase(12030405670809, 9)]
        public void DigitalRoot_Test(long n, int expected)
        {
            Assert.AreEqual(expected, num.DigitalRoot(n));
        }
    }
}
