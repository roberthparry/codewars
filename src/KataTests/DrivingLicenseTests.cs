using NUnit.Framework;
using System;

using Kata;

namespace KataTests
{
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void KataTest1()
        {
            var test = new DrivingLicence();
            string[] data = new string[] { "John", "James", "Smith", "01-Jan-2000", "M" };
            Assert.AreEqual("SMITH001010JJ9AA", test.driver(data));
        }

        [TestCase]
        public void KataTest2()
        {
            var test = new DrivingLicence();
            string[] data = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };
            Assert.AreEqual("GIBBS862131J99AA", test.driver(data));
        }

        [TestCase]
        public void KataTest3()
        {
            var test = new DrivingLicence();
            string[] data = new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
            Assert.AreEqual("LEE99809021AR9AA", test.driver(data));
        }
    }
}