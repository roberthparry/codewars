using Kata;

namespace KataTests
{
    using NUnit.Framework;

    [TestFixture]
    public class LinearSystemTests
    {
        [Test]
        public void TestAndVerify1()
        {
            LinearSystem ls = new LinearSystem();
            string input = "1 2 0 7\r\n0 2 4 8\r\n0 5 6 9";
            string result = ls.Solve(input);
            Assert.AreEqual("SOLUTION=(10; -1.5; 2.75)", result);
        }
        [Test]
        public void TestAndVerify2()
        {
            LinearSystem ls = new LinearSystem();
            string input = "1 2 0 4 7\r\n0 2 0 2 8\r\n0 0 -1 4 6\r\n1 2 3 2 3";
            string result = ls.Solve(input);
            Assert.AreEqual("SOLUTION=(-3.8; 2.6; -0.4; 1.4)", result);
        }

        [Test]
        public void TestAndVerify3()
        {
            LinearSystem ls = new LinearSystem();
            string input = "1 2 1\r\n1 2 0";
            string result = ls.Solve(input);
            Assert.AreEqual("SOLUTION=NONE", result);
        }
    }
}