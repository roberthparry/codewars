using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    class DrivingLicenseTest
    {
        [TestCase]
        public void Test1()
        {
            var test = new DrivingLicence();
            string[] data = new string[] { "John", "James", "Smith", "01-Jan-2000", "M" };
            Assert.AreEqual("SMITH001010JJ9AA", test.Driver(data));
        }

        [TestCase]
        public void Test2()
        {
            var test = new DrivingLicence();
            string[] data = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };
            Assert.AreEqual("GIBBS862131J99AA", test.Driver(data));
        }

        [TestCase]
        public void Test3()
        {
            var test = new DrivingLicence();
            string[] data = new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
            Assert.AreEqual("LEE99809021AR9AA", test.Driver(data));
        }
    }
}