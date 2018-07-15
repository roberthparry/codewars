using NUnit.Framework;
using System;

namespace CodeWars
{
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void KataTest1()
        {
            Kata test = new Kata();
            string[] data = new string[] { "John", "James", "Smith", "01-Jan-2000", "M" };
            Assert.AreEqual("SMITH001010JJ9AA", test.driver(data));
        }

        [TestCase]
        public void KataTest2()
        {
            Kata test = new Kata();
            string[] data = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };
            Assert.AreEqual("GIBBS862131J99AA", test.driver(data));
        }

        [TestCase]
        public void KataTest3()
        {
            Kata test = new Kata();
            string[] data = new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
            Assert.AreEqual("LEE99809021AR9AA", test.driver(data));
        }
    }
}