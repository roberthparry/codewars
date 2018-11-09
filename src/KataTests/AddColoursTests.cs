using NUnit.Framework;
using Kata;

namespace KataTests
{
	[TestFixture]
    public class AddColorsTests
    {
        [TestCase("Green", "Green")]
        [TestCase("Yellow", "Red,Green")]
        public void AdditiveColors_Test(string expected, string mix)
        {
            Assert.AreEqual(expected, AddColors.AdditiveColors(mix));
        }
    }
}
