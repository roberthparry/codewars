using NUnit.Framework;
using System;
using System.Numerics;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void basicTests()
        {
            Assert.AreEqual(new BigInteger(0), PipiNumbers.Pipi(0));
            Assert.AreEqual(new BigInteger(1), PipiNumbers.Pipi(1));
            Assert.AreEqual(new BigInteger(9), PipiNumbers.Pipi(2));
            Assert.AreEqual(new BigInteger(3025), PipiNumbers.Pipi(3));
            Assert.AreEqual(new BigInteger(1903664161), PipiNumbers.Pipi(4));
            Assert.AreEqual(BigInteger.Parse("9903365616948251868225"), PipiNumbers.Pipi(5));
            Assert.AreEqual(BigInteger.Parse("22309173926869425179456178309988068048151564650625"), PipiNumbers.Pipi(6));
            Assert.AreEqual(BigInteger.Parse("347344242690551218689875522294777681772995698601451664233760078879673569943084142016961541085081108860391681"), PipiNumbers.Pipi(7));
        }
    }
}