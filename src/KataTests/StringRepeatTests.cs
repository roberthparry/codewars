﻿using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class StringRepeatTests
    {
        [TestCase(3, "*", "***")]
        [TestCase(0, "Hello", "")]
		[TestCase(5, "Hello", "HelloHelloHelloHelloHello")]
        public void MyTest(int n, string s, string expected)
        {
            Assert.AreEqual(expected, StringRepeat.RepeatStr(n, s));
        }
    }
}