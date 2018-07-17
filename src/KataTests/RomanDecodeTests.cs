using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class RomanDecodeTests
    {
        [TestCase(1, "I")]
        public void Test(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }
    }
}


