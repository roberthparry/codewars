namespace KataTests
{
    using NUnit.Framework;
    using Kata;

    [TestFixture]
    public class ArrayDifferenceTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 2 }, ArrayDifference.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, ArrayDifference.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, ArrayDifference.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, ArrayDifference.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, ArrayDifference.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
        }
    }
}