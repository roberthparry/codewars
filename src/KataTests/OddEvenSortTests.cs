using Kata;

namespace KataTests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class OddEvenSortTests
    {
        private static readonly object[] _testCases = new object[]
        {
            new object[] {"CodeWars", "CdWr oeas"},
            new object[] {"YCOLUE'VREER", "YOU'RE CLEVER"},
        };

        [Test, TestCaseSource(nameof(_testCases))]
        public void Test(string s, string expected) => Assert.AreEqual(expected, OddEvenSort.SortMyString(s));
    }
}