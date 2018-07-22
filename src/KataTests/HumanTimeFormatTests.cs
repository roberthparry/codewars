using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class HumanTimeFormatTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual("now", HumanTimeFormat.formatDuration(0));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual("1 second", HumanTimeFormat.formatDuration(1));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual("1 minute and 2 seconds", HumanTimeFormat.formatDuration(62));
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual("2 minutes", HumanTimeFormat.formatDuration(120));
        }

        [Test]
        public void test5()
        {
            Assert.AreEqual("1 hour, 1 minute and 2 seconds", HumanTimeFormat.formatDuration(3662));
        }

        [Test]
        public void test6()
        {
            Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", HumanTimeFormat.formatDuration(242062374));
        }
    } 
}


