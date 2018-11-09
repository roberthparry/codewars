using NUnit.Framework;
using System.Numerics;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class PipiNumbersTests
    {
        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(2, "9")]
        [TestCase(3, "3025")]
        [TestCase(4, "1903664161")]
        [TestCase(5, "9903365616948251868225")]
        [TestCase(6, "22309173926869425179456178309988068048151564650625")]
        [TestCase(7, "347344242690551218689875522294777681772995698601451664233760078879673569943084142016961541085081108860391681")]
        public void Pipi_Number(int n, string expected)
        {
            Assert.AreEqual(BigInteger.Parse(expected), PipiNumbers.Pipi(n));
        }
    }
}