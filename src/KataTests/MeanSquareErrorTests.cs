using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class MeanSquareErrorTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(9, MeanSquareError.Solution(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(16.5, MeanSquareError.Solution(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }));
            Assert.AreEqual(1, MeanSquareError.Solution(new int[] { 0, -1 }, new int[] { -1, 0 }));
        }
    }
}
