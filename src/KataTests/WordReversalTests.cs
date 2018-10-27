namespace KataTests
{
    using NUnit.Framework;
    using Kata;

    [TestFixture]
    public class WordReversalTests
    {

        [Test]
        public void BasicTests()
        {
            var kata = new WordReversal();

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krishan"));

            Assert.AreEqual("nortlu", kata.ReverseLetter("ultr53o?n"));

            Assert.AreEqual("cba", kata.ReverseLetter("ab23c"));

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krish21an"));

        }

    }
}