using NUnit.Framework;
using System;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class SortStarTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", SortStar.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
            Assert.AreEqual("a***r***e", SortStar.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
        }
    }
}