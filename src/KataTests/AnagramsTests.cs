using NUnit.Framework;
using System.Collections.Generic;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class AnagramsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<string> { "a" }, Anagrams.FindAnagrams("a", new List<string> { "a", "b", "c", "d" }));
			Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Anagrams.FindAnagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
    }
}