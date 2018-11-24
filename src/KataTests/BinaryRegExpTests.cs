using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class BinaryRegExpTests
    {
        static readonly String _rgxStr = BinaryRegExp.MultipleOf7();

        private static IEnumerable<TestCaseData> MultipleOfSevenTestCases
        {
            get
            {
                yield return new TestCaseData("").Returns(false);
                yield return new TestCaseData("0").Returns(true);
                for (int i = 1; i < 100; i++)
                    yield return new TestCaseData(Convert.ToString(i, 2)).Returns(i % 7 == 0);
            }
        }

        [Test, TestCaseSource(nameof(MultipleOfSevenTestCases))]
        public bool MultipleOf7_Test(string binary)
        {
            return Regex.Match(binary, _rgxStr).Success;
        }
    }
}