using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    class FixStringTests
    {
        [TestCase("code", "code")]
        [TestCase("CODe", "CODE")]
        [TestCase("COde", "code")]
        [TestCase("Code", "code")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(FixString.Solve(s), Is.EqualTo(expected));
        }
    } 
}
