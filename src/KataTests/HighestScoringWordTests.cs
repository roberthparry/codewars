using NUnit.Framework;
using System.Collections.Generic;
using Kata;

namespace KataTests
{
	[TestFixture]
    public class HighestScoringWordTests
    {
        private static IEnumerable<TestCaseData> _testCases
        {
            get
            {
                yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
                yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
                yield return new TestCaseData("take me to semynak").Returns("semynak");
            }
        }

        [Test, TestCaseSource("_testCases")]
		public string HighestScoringWordTest(string s) => HighestScoringWord.High(s);

		[Test, TestCaseSource("_testCases")]
        public string HighestScoringWordTestSimple(string s) => HighestScoringWord.HighSimple(s);
    }
}
