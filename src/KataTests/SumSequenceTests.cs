using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class ComparingTests
    {
        [TestCase(-1, "-1<0")]
        [TestCase(0, "0=0")]
        [TestCase(3, "0+1+2+3 = 6")]
        [TestCase(10, "0+1+2+3+4+5+6+7+8+9+10 = 55")]
        public void SequenceTest1(int n, string sequenceString)
        {
            Assert.AreEqual(sequenceString, SumSequence.SequenceString(n));
        }

        [TestCase(-1, "-1<0")]
        [TestCase(0, "0=0")]
        [TestCase(3, "0+1+2+3 = 6")]
        [TestCase(10, "0+1+2+3+4+5+6+7+8+9+10 = 55")]
        public void SequenceTest2(int n, string sequenceString)
        {
            Assert.AreEqual(sequenceString, SumSequence.ShowSequence(n));
        }
    }
}
