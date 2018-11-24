using NUnit.Framework;
using System.Collections.Generic;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        private static IEnumerable<TestCaseData> SampleTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
                yield return new TestCaseData(7).Returns(true);
                yield return new TestCaseData(11).Returns(true);
                yield return new TestCaseData(13).Returns(true);
                yield return new TestCaseData(15).Returns(false);
                yield return new TestCaseData(17).Returns(true);
                yield return new TestCaseData(199).Returns(true);
                yield return new TestCaseData(7867).Returns(true);
                yield return new TestCaseData(16769023).Returns(true);
            }
        }

        [Test, TestCaseSource(nameof(SampleTestCases))]
        public bool IsPrime_Test(int n) => PrimeNumbers.IsPrime(n);
    }
}