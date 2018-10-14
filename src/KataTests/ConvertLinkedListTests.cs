using NUnit.Framework;
using Kata;
using System.Collections.Generic;

namespace KataTests
{
    [TestFixture]
    public class ConvertLinkedListTests
    {
		private static IEnumerable<TestCaseData> _testCases
        {
            get
            {
				yield return new TestCaseData(null).Returns("null");
				yield return new TestCaseData(new Node(0, new Node(1, new Node(4, new Node(9, new Node(16)))))).Returns("0 -> 1 -> 4 -> 9 -> 16 -> null");
				yield return new TestCaseData(new Node(1, new Node(2, new Node(3)))).Returns("1 -> 2 -> 3 -> null");
            }
        }

		[Test, TestCaseSource("_testCases")]
        public string SampleTest(Node list)
        {
			return ConvertLinkedList.Stringify(list);
        }
    }
}
