using NUnit.Framework;
using System.Collections;
using Kata;

namespace KataTests
{
    [TestFixture]
    public static class ParityOutlierTests
    {
        public class ParityOutlierTestCase
        {
            public int[] Integers { get; private set; }

            public ParityOutlierTestCase(params int[] integers)
            {
                Integers = integers;
            }

            public override string ToString()
            {
                return string.Join(",", Integers);
            }
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new ParityOutlierTestCase(2, 6, 8, -10, 3)).Returns(3);
                yield return new TestCaseData(new ParityOutlierTestCase(206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781)).Returns(206847684);
                yield return new TestCaseData(new ParityOutlierTestCase(int.MaxValue, 0, 1)).Returns(0);
            }
        }

        [Test, TestCaseSource(typeof(ParityOutlierTests), nameof(TestCases))]
        public static int Find_Test(ParityOutlierTestCase testCase) => ParityOutlier.Find(testCase.Integers);
    }
}
