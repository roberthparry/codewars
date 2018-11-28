using System;
using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public static class SumFractionsTests
    {
        private static void Testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void Test()
        {
            Console.WriteLine("Fixed Tests");
            int[,] a = new int[,] { { 1, 2 }, { 2, 9 }, { 3, 18 }, { 4, 24 }, { 6, 48 } };
            String r = "[85, 72]";
            Testing(SumFractions.SumFracts(a), r);
            a = new int[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            r = "[13, 12]";
            Testing(SumFractions.SumFracts(a), r);
            a = new int[,] { { 1, 3 }, { 5, 3 } };
            r = "2";
            Testing(SumFractions.SumFracts(a), r);
            a = new int[,] { };
            r = null;
        }
    }
}
