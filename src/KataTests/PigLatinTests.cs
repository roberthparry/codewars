using NUnit.Framework;

using Kata;

namespace KataTests
{
	[TestFixture]
	public class PigLatinTests
    {
		[TestCase("Pig latin is cool", "igPay atinlay siay oolcay")]
		[TestCase("This is my string", "hisTay siay ymay tringsay")]
        public void PigLatinTest(string statement, string translated)
        {
			Assert.AreEqual(translated, PigLatin.PigIt(statement));
        }
    }
}
