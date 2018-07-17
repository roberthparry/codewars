namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class OddEvenSortTests
    {
        private static object[] testCases = new object[]
        {
            new object[] {"CodeWars", "CdWr oeas"},
            new object[] {"YCOLUE'VREER", "YOU'RE CLEVER"},
        };

        [Test, TestCaseSource("testCases")]
        public void Test(string s, string expected) => Assert.AreEqual(expected, OddEvenSort.SortMyString(s));
    }
}