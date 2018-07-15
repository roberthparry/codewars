using NUnit.Framework;

[TestFixture]
class Tetst
{
    [TestCase("code", "code")]
    [TestCase("CODe", "CODE")]
    [TestCase("COde", "code")]
    [TestCase("Code", "code")]
    public void BasicTests(string s, string expected)
    {
        Assert.That(Kata.Solve(s), Is.EqualTo(expected));
    }
}