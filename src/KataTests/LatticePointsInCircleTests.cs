using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class LatticePointsInCircleTests
    {
        [TestCase(1, 5)]
        [TestCase(2, 13)]
        [TestCase(3, 29)]
        [TestCase(5, 81)]
        [TestCase(1000, 3141549)]
        [TestCase(10000, 314159053)]
        public void PointsInCircle_Test(int radius, int numPoints)
        {
            Assert.AreEqual(numPoints, LatticePointsInCircle.PointsInCircle(radius));
        }
    }
}
