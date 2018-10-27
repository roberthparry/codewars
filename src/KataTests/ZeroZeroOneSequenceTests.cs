using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class ZeroZeroOneSequenceTests
    {
        [Test]
        public void FetchesCurrectSequence()
        {
            Assert.AreEqual(new int[] { 0, 0, 1, 0, 0, 1, 0, 0, 1 }, ZeroZeroOneSequence.Fetch(9));
        }
    }
}
