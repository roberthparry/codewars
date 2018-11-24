namespace KataTests
{
    using NUnit.Framework;
    using System.Collections.Generic;
	using Kata;

    [TestFixture]
    public class SumTreeKataTests
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
				yield return new TestCaseData(new SumTreeKata.Node(10, new SumTreeKata.Node(1), new SumTreeKata.Node(2))).Returns(13).SetDescription("Simple Test");
				yield return new TestCaseData(new SumTreeKata.Node(11, new SumTreeKata.Node(0), new SumTreeKata.Node(0, null, new SumTreeKata.Node(1)))).Returns(12).SetDescription("Handles unbalanced trees");
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public int Test(SumTreeKata.Node root) => SumTreeKata.SumTree(root);
    }
}
