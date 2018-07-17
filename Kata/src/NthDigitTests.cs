using Kata;

namespace KataTests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class NthDigitTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(5, NthDigit.FindDigit(5673, 4));
            Assert.AreEqual(2, NthDigit.FindDigit(129, 2));
            Assert.AreEqual(8, NthDigit.FindDigit(-2825, 3));
            Assert.AreEqual(0, NthDigit.FindDigit(-456, 4));
            Assert.AreEqual(0, NthDigit.FindDigit(0, 20));
            Assert.AreEqual(-1, NthDigit.FindDigit(65, 0));
            Assert.AreEqual(-1, NthDigit.FindDigit(24, -8));
        }
    }
}