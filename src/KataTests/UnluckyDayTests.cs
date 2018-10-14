using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class UnluckyDayTests
    {
        [Test]
        public void BasicTests()
        {
			Assert.AreEqual(1, UnluckyDay.UnluckyDays(1586));
			Assert.AreEqual(3, UnluckyDay.UnluckyDays(1001));
			Assert.AreEqual(2, UnluckyDay.UnluckyDays(2819));
			Assert.AreEqual(2, UnluckyDay.UnluckyDays(2792));
			Assert.AreEqual(2, UnluckyDay.UnluckyDays(2723));
			Assert.AreEqual(1, UnluckyDay.UnluckyDays(1909));
			Assert.AreEqual(2, UnluckyDay.UnluckyDays(1812));
			Assert.AreEqual(2, UnluckyDay.UnluckyDays(1618));
			Assert.AreEqual(1, UnluckyDay.UnluckyDays(2132));
			Assert.AreEqual(3, UnluckyDay.UnluckyDays(2065));
        }
    }
}