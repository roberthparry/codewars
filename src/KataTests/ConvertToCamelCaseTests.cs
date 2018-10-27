using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class ConvertToCamelCaseTests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", ConvertToCamelCase.ToCamelCase("the_stealth_warrior"), "ConvertToCamelCase.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", ConvertToCamelCase.ToCamelCase("The-Stealth-Warrior"), "ConvertToCamelCase.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}
