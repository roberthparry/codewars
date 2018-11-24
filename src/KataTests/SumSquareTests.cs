using System.Collections.Generic;
using NUnit.Framework;
using Kata;

namespace KataTests 
{

    [TestFixture]
    public class SumSquareTests
    {
        private static IEnumerable<TestCaseData> SampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
            }
        }

        [Test, TestCaseSource(nameof(SampleTestCases)), Description("Sample Tests")]
        public int SampleTest(int[] n) => SumSquare.SquareSum(n);
    } 
}
