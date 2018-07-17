using Kata;

namespace KataTests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class StringRepeatTests
    {
        [TestCase(3, "*", "***")]
        [TestCase(0, "Hello", "")]
		[TestCase(5, "Hello", "HelloHelloHelloHelloHello")]
        public void MyTest(int n, string s, string expected)
        {
            Assert.AreEqual(expected, StringRepeat.repeatStr(n, s));
        }
    }
}