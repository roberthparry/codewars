using System;
using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public static class ThirteenTests
    {

        private static void Testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test1()
        {
            Console.WriteLine("Testing Thirt");
            Testing(Thirteen.Thirt(8529), 79);
            Testing(Thirteen.Thirt(85299258), 31);
            Testing(Thirteen.Thirt(5634), 57);
            Testing(Thirteen.Thirt(1111111111), 71);
            Testing(Thirteen.Thirt(987654321), 30);
        }
    }
}

