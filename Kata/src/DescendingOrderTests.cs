using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class DescendingOrderTests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, DescendingOrderSolution.DescendingOrder(0));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(65321, DescendingOrderSolution.DescendingOrder(12356));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(55554443, DescendingOrderSolution.DescendingOrder(54545543));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(988744322, DescendingOrderSolution.DescendingOrder(782498423));
        }
    }    
}
