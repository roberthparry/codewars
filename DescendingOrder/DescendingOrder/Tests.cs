using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void Test0()
    {
        Assert.AreEqual(0, Kata.DescendingOrder(0));
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual(65321, Kata.DescendingOrder(12356));
    }
    [Test]
    public void Test2()
    {
        Assert.AreEqual(55554443, Kata.DescendingOrder(54545543));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(988744322, Kata.DescendingOrder(782498423));
    }
}