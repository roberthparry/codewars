namespace KataTests
{
    using NUnit.Framework;
    using Kata;

    [TestFixture]
    public class IntegerDepthTest
    {

        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(10, IntegerDepth.ComputeDepth(1));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(9, IntegerDepth.ComputeDepth(42));
        }

    }
}